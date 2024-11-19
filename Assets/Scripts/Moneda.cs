using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour
{
    public GameObject objPuntos;
    public float puntosqda;
    public AudioSource AudioMoneda;
    public GameObject panel; // Agrega tu panel aquí
    public Text panelText;
    private Animator panelAnimator; // Referencia al Animator del panel
    

    private void Start()
    {
        // Asegúrate de que tu panel tiene un componente Animator
        panelAnimator = panel.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objPuntos.GetComponent<Puntos>().puntos += puntosqda;
            Destroy(gameObject);
            AudioMoneda.Play();

            // Mostrar el panel cuando el jugador recoja una moneda
            panel.SetActive(true);
            panelText.text = "+1 coin";
            // Iniciar la animación del panel
            panelAnimator.Play("fadecoin"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animaciónda!";
            Invoke("OcultarTexto", 0.5f);
        }
    }
    // Método para ocultar el texto
    void OcultarTexto()
    {
        panelText.text = "";
    }
}
