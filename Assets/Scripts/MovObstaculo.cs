using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObstaculo : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento
    public float distancia = 10.0f; // Distancia que el obstáculo recorre en una dirección

    private Vector3 inicioPosicion;
    private int direccion = 1;
    // Start is called before the first frame update
    void Start()
    {
        inicioPosicion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el obstáculo en la dirección actual
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime * direccion);

        // Comprobar si el obstáculo ha recorrido la distancia deseada
        if (Vector3.Distance(transform.position, inicioPosicion) >= distancia)
        {
            // Cambiar la dirección y regresar al inicio
            direccion *= -1;
        }
    }
}
