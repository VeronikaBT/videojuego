using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;
    public float adelante = 2000;
    public float lado = 2000;
    public Text score;
    public float empuje = 10;
    //Cuando esfera esta en el plano
    bool m_insGrounded = true;
    public AudioSource salto;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            //Ejes x,y,z
            rb.AddForce(0, 0, adelante * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            //Ejes x,y,z
            rb.AddForce(0, 0, -adelante * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            //Ejes x,y,z
            rb.AddForce(lado * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            //Ejes x,y,z
            rb.AddForce(-lado * Time.deltaTime, 0, 0);
        }
        //Para saltar
        if (Input.GetKeyDown(KeyCode.Space) && m_insGrounded == true)
        {
            Jump();
            salto.Play();
        }
        //Generar puntaje
        score.text = transform.position.z.ToString("0");
    }

    public void Jump()
    {
        //Ya no esta em el plano
        m_insGrounded = false;
        rb.AddForce(0, empuje, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            //Cuando esfera esta en el plano
            m_insGrounded = true;
        }

    }
}
