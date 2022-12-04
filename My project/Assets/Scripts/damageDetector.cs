using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageDetector : MonoBehaviour
{
    public SpriteRenderer vida;
    public Sprite mediavida;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<playerController>().lifePoints == 1)
        {
            vida.sprite = mediavida;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            
            FindObjectOfType<playerController>().lifePoints = FindObjectOfType<playerController>().lifePoints - 1;
            if (transform.rotation.y == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000, 0));
            }
            else
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000, 0));
        }
    }
}
