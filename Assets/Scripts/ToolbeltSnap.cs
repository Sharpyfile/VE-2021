using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolbeltSnap : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject snapObject = null;

    // Update is called once per frame
    void Update()
    {
        if (snapObject)
        {
            snapObject.transform.position = transform.position;
            snapObject.transform.rotation = transform.rotation;
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GrabObject")
        {
            Debug.Log(other.tag);
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().Sleep();
            snapObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (snapObject)
            snapObject.transform.position = transform.position;
        if (other.tag == "GrabObject" && other.gameObject == snapObject)
        {
            snapObject = null;
        }
    }
}
