using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoxSnap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GrabObject")
        {
            Debug.Log(other.tag);
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
        }
    }
}
