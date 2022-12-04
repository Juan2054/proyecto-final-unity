using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
