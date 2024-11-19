using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public float puntos;
    public Text textopuntos;

    private void Update()
    {
        textopuntos.text = "+"+ puntos.ToString();
    }
}
