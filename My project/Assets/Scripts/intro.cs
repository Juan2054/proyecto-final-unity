using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enummerador());
    }

    IEnumerator enummerador()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
