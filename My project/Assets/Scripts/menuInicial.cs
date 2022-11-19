using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
