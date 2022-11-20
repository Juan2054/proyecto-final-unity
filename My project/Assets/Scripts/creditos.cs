using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enummerador());
    }

    IEnumerator enummerador()
    {
        yield return new WaitForSeconds(22);
        Debug.Log("Salir...");
        Application.Quit();
    }
}
