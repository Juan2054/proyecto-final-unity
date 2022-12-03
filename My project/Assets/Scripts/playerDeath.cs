using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<playerController>().lifePoints == 0 || transform.position.y < -8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
