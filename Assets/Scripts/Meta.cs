using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject panel; // Agrega tu panel aqu�
    public Text panelText;
    private Animator panelAnimator; // Referencia al Animator del panel

    private void Start()
    {
        // Aseg�rate de que tu panel tiene un componente Animator
        panelAnimator = panel.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Mostrar el panel cuando el jugador llegue a la meta
            panel.SetActive(true);
            panelText.text = "Haz completado el nivel";

            // Iniciar la animaci�n del panel
            panelAnimator.Play("FadeM"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animaci�n

            //Mostrar siguiente escena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
