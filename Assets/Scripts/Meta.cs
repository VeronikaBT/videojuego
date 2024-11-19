using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject panel; // Agrega tu panel aquí
    public Text panelText;
    private Animator panelAnimator; // Referencia al Animator del panel

    private void Start()
    {
        // Asegúrate de que tu panel tiene un componente Animator
        panelAnimator = panel.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Mostrar el panel cuando el jugador llegue a la meta
            panel.SetActive(true);
            panelText.text = "Haz completado el nivel";

            // Iniciar la animación del panel
            panelAnimator.Play("FadeM"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animación

            //Mostrar siguiente escena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
