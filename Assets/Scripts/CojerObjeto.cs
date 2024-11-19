using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CojerObjeto : MonoBehaviour
{
    public GameObject handPoint;
    private GameObject picketObjetct = null;
    // Update is called once per frame
    void Update()
    {
        if (picketObjetct != null)
        {
            if (Input.GetKey("r"))
            {
                picketObjetct.GetComponent<Rigidbody>().useGravity = true;
                picketObjetct.GetComponent<Rigidbody>().isKinematic = false;
                picketObjetct.gameObject.transform.SetParent(null);
                picketObjetct = null;
            }
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto"))
        {
            if (Input.GetKey("e") && picketObjetct == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                picketObjetct = other.gameObject;
            }
        }
    }

}
