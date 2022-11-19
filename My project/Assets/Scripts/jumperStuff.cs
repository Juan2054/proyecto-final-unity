using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumperStuff : MonoBehaviour
{
    public int lifePoints;
    public float jumpForce;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifePoints <= 0)
        {
            Destroy(gameObject);
        }

        if (jump)
        {
            jump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            jump = true;
        }
    }
}
