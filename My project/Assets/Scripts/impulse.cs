using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulse : MonoBehaviour
{
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
            FindObjectOfType<Health>().lifePoints = FindObjectOfType<Health>().lifePoints - damage;
            Destroy(gameObject);
        }
        if (collision.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }


}
