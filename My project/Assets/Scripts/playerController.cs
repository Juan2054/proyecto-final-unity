using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int score;
    public TMP_Text puntos;
    private int jumps;
    public int lifePoints;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = score.ToString();
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            if (gameObject.GetComponent<Animator>().GetBool("jumping") == false)
            {
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }
        }
        if(Input.GetKey("left"))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
            if (gameObject.GetComponent<Animator>().GetBool("jumping") == false)
            {
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if(Input.GetKeyDown("up") && jump)
        {
            if (jumps <= 0)
            {
                jump = false;
            }
            jumps = jumps - 1;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            gameObject.GetComponent<Animator>().SetBool("moving", false);

        }
        if(Input.GetKey(KeyCode.Escape))
            Application.Quit();


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            jump = true;
            jumps = 1;
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
        }
    }
}


