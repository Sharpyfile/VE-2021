using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeverTest : MonoBehaviour
{
    public TextMeshPro text;
    public Transform leverTransform;
    public HingeJoint leverJoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = leverJoint.angle.ToString();
    }
}
