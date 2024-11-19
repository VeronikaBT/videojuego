using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformacolision : MonoBehaviour
{
    public GameObject[] waypoints;
    public float speed = 2;
    private int index = 0;
    private bool isPlayerOnPlatform = false; // Nueva variable

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlataform();
    }

    void MovePlataform()
    {
        if (isPlayerOnPlatform) // Solo mueve la plataforma si el jugador está en ella
        {
            if (Vector3.Distance(transform.position, waypoints[index].transform.position) < 0.1f)
            {
                index++;
                if (index >= waypoints.Length)
                {
                    index = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position,
            waypoints[index].transform.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
            isPlayerOnPlatform = true; // Establece la variable en true cuando el jugador colisiona con la plataforma
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
            isPlayerOnPlatform = false; // Establece la variable en false cuando el jugador deja la plataforma
        }
    }
}
