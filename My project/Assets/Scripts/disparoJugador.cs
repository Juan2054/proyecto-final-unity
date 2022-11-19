using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoJugador : MonoBehaviour
{

    public Transform ctrlShot;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }   
    }

    private void Shot()
    {
        Instantiate(bala, ctrlShot.position, ctrlShot.rotation);
    }
}
