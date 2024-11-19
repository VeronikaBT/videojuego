using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Obstaculo : MonoBehaviour
{
    BarraVida playerVida;
    public AudioSource golpe;
    public GameObject panel; // Agrega tu panel aqu�
    public Text panelText; // Agrega tu componente de texto aqu�
    private Animator panelAnimator; // Referencia al Animator del panel

    private void Start()
    {
        // Aseg�rate de que tu panel tiene un componente Animator
        panelAnimator = panel.GetComponent<Animator>();
    }

    //Para conocer con que objeto a colisionado
    private void OnCollisionEnter(Collision collision)
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();

        if (collision.transform.CompareTag("Player"))
        {
            playerVida.vidaActual -= 20;
            golpe.Play();
            //Regresar la esfera a su posici�n inicial
            GameObject.FindWithTag("Player").transform.position = new Vector3((float)0.360000, 2, 0);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            //Cuando la barra de vida llegue a 0
            if (playerVida.vidaActual == 0)
            {
                //Carga la escena de Game Over
                SceneManager.LoadScene(3);
            }

            // Mostrar el panel cuando ocurre una colisi�n
            panel.SetActive(true);
            panelText.text = "-1";

            // Iniciar la animaci�n del panel
            panelAnimator.Play("FadeChoque"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animaci�n
            Invoke("OcultarTexto", 0.5f);
        }
    }
    // M�todo para ocultar el texto
    void OcultarTexto()
    {
        panelText.text = "";
    }
}