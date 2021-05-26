using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToActivate;
    public float activationAngle = -160.0f;
    private HingeJoint lever;
    public bool action;
    void Start()
    {
        lever = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lever.angle <= activationAngle)
        {
            objectToActivate.SetActive(action);
            lever.GetComponent<Rigidbody>().freezeRotation = true;
        }
            
    }
}
