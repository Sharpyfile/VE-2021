using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightReveal : MonoBehaviour
{
    public Material reveal;
    public Light flashlight;

    // Update is called once per frame
    void Update()
    {
        reveal.SetVector("_LightPosition", flashlight.transform.position);
        reveal.SetVector("_LightDirection", flashlight.transform.forward);
        reveal.SetFloat("_LightAngle", flashlight.spotAngle);
    }
}
