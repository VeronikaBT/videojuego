using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textomoneda : MonoBehaviour
{
    // Start is called before the first frame update

    public float TiempoVida = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoVida -= Time.deltaTime;
        if (TiempoVida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
