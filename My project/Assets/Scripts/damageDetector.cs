using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageDetector : MonoBehaviour
{
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            FindObjectOfType<playerController>().lifePoints = FindObjectOfType<playerController>().lifePoints - 1;
        }
    }
}
