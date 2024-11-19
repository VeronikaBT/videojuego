using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inicio : MonoBehaviour
{
    // Start is called before the first frame update
    public Text dialogueText;
    public GameObject dialoguePanel;
    public string initialDialogue = "¡Bienvenido al juego!\n\nControles:\n- Moverse: A,W,S,D\n- Saltar: Barra espaciadora";

    private bool hasDisplayed = false;
    void Start()
    {
        dialogueText.text = initialDialogue;
        dialoguePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !hasDisplayed) 
        {
            dialoguePanel.SetActive(false);
            hasDisplayed = true;
        }
    }
}
