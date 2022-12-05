using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerDeathLevel2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Controladorjugador>().lifePoints <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
