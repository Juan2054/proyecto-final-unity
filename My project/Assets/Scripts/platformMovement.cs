using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    bool direction = true;
    public float speedX;
    public float speedY;
    public int distanceX;
    public int distanceY;
    private Vector3 initPos;
    private Vector3 finalPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        finalPos = new Vector3(initPos.x + distanceX, initPos.y + distanceY, 0);
        Debug.Log(initPos); 
        Debug.Log(finalPos);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < initPos.x)
        {
            direction = true;
        }
        else if (transform.position.x > finalPos.x)
        {
            direction = false;
        }

        if (direction)
        {
            transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(-speedX * Time.deltaTime, -speedY * Time.deltaTime, 0);
        }
    }

}
