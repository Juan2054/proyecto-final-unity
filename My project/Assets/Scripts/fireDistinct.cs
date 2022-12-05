using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireDistinct : MonoBehaviour
{
    public Transform vida;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<FireBullets>().enabled = true;
    }

    void Update()
    {
        cambiar();
    }

    void cambiar()
    {
        if(FindObjectOfType<MovimientoBoss>().lifePoints <= 3)
        {
            this.GetComponent<FireBullets3>().enabled = true;
        }
    }
}
