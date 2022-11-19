using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulse : MonoBehaviour
{
    public GameObject enemy;
    public float impulso;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * impulso * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            enemy.GetComponent<jumperStuff>().lifePoints = 0;
        }
        else if (collision.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}
