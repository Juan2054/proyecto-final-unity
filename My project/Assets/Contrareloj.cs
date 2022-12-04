using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contrareloj : MonoBehaviour
{
    [SerializeField]
    private float tiempoMaximo;

    private float tiempoActual;

    private bool tiempoActivado = false;

    private void Start()
    {
        ActivarTemporizador();
    }

    private void Update()
    {
        if (tiempoActivado)
        {
            cambiarContador();
        }
    }

    private void cambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual <= 0)
        {
            Debug.Log("Win");
            CambiarTemporizador(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    private void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        CambiarTemporizador(true);
    }

    private void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }
}
