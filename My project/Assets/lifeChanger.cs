using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeChanger : MonoBehaviour
{
    public Transform vidaNave;
    public GameObject nave;
    public bool mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mode)
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        //Vector3(-22.8069992,4.03299999,0)
        if (transform.position.x <= -24)
        {
            transform.position = new Vector3(-4, 4.03299999f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bullet"))
        {
            transform.position = new Vector3(-4, 4.03299999f, 0);
            nave.GetComponent<spaceshipController>().lifePoints = 5;
            vidaNave.transform.localScale = new Vector3(5, 0.4f, 0);
            
            mode = false;
        }
    }
}
