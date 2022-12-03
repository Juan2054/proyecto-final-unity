using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    private EnemyData data;

    private GameObject player;

    public Transform playerTransform;

    bool jump;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    private void SetEnemyValues()
    {
        GetComponent<Health>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

    private void Swarm()
    {
        if(transform.position.x > playerTransform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (transform.position.x < playerTransform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (transform.position.y < playerTransform.position.y && jump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.transform.tag == "ground")
        {
            jump = true;
        }

        if (collider.collider.tag == "Player")
        {
            if (FindObjectOfType<Health>() != null)
            {
                FindObjectOfType<Health>().Damage(damage);
                this.GetComponent<Health>().Damage(10000);
            }
        }
    }
}
