using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public Text textoTimer;
    public string tiempo;
    public GameObject panel; // Agrega tu panel aquí
    public Text panelText;
    private Animator panelAnimator; // Referencia al Animator del panel

    // Start is called before the first frame update
    void Start()
    {
        // Asegúrate de que tu panel tiene un componente Animator
        panelAnimator = panel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //aumentar
        //timer += Time.deltaTime;
        //disminuir
        timer -= Time.deltaTime;
        tiempo = "" + timer.ToString("f0");
        textoTimer.text = "" + timer.ToString("f0") + " s";

        if (tiempo.Equals("10"))
        {
            // Mostrar el panel cuando el temporizador llegue a 10 segundos
            panel.SetActive(true);

            // Iniciar la animación del panel
            panelAnimator.Play("FadeT"); // Reemplaza "NombreDeTuAnimacion" con el nombre de tu animación
            panelText.text = "¡10 segundos!";
        }

        if (tiempo.Equals("0"))
        {
            //Reiniciar la escena o GameOver
            //Carga la escena de Game Over
            SceneManager.LoadScene(3);
        }
    }
}
