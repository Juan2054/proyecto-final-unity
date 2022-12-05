using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoBoss : MonoBehaviour
{
    private float moveSpeed;
    private bool moveRight;
    public Transform vida;
    public float lifePoints;
    int prueba;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        moveRight = true;
        lifePoints = vida.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -5f)
        {
            moveRight = false;
        }
        else if (transform.position.x < -21f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,
                transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime,
                transform.position.y);
        }

        if (lifePoints <= 0)
        {
            gameObject.GetComponent<Animator>().SetBool("IsDeath", true);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            vida.transform.localScale = new Vector3(lifePoints - 0.1f, 0.4f, 0);
            lifePoints -= 0.1f;
        }
    }

    private void End()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
