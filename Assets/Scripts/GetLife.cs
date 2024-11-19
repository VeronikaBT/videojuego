using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GetLife : MonoBehaviour
{
    BarraVida playerVida;
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
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();
        if (other.tag == "Player")
        {
            AudioMoneda.Play();
            playerVida.vidaActual += 20;
            Destroy(gameObject);

            // Mostrar el panel cuando el jugador obtenga vida
            panel.SetActive(true);
            panelText.text = "+1";

            // Iniciar la animación del panel
            panelAnimator.Play("Fadelife"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animación
            Invoke("OcultarTexto", 0.2f);
        }
    }
    // Método para ocultar el texto
    void OcultarTexto()
    {
        panelText.text = "";
    }
}
