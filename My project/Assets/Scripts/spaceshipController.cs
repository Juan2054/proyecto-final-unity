using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spaceshipController : MonoBehaviour
{
    public float speed;
    public GameObject vida;
    public GameObject minion;
    public float lifePoints;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        lifePoints = vida.transform.localScale.x;
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

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();

        if (lifePoints < 2.5f)
        {
            minion.GetComponent<lifeChanger>().mode = true;
        }
        if (lifePoints <= 0)
        {
            vida.transform.localScale = new Vector3(0, 0.4f, 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bulletBoss"))
        {
            vida.transform.localScale = new Vector3(lifePoints - damage, 0.4f, 0);
            lifePoints -= damage;
            Debug.Log(lifePoints);
        }    
    }
}
