using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<playerController>().score = FindObjectOfType<playerController>().score + 1;
            Destroy(gameObject);
        }
    }
}
