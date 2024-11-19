using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GetLife : MonoBehaviour
{
    BarraVida playerVida;
    public AudioSource AudioMoneda;
    public GameObject panel; // Agrega tu panel aqu�
    public Text panelText;
    private Animator panelAnimator; // Referencia al Animator del panel

    private void Start()
    {
        // Aseg�rate de que tu panel tiene un componente Animator
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

            // Iniciar la animaci�n del panel
            panelAnimator.Play("Fadelife"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animaci�n
            Invoke("OcultarTexto", 0.2f);
        }
    }
    // M�todo para ocultar el texto
    void OcultarTexto()
    {
        panelText.text = "";
    }
}
