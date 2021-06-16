using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FPSCounter : MonoBehaviour
{
    private TextMeshPro text;
    void Start()
    {
        text = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ((int)(1f / Time.unscaledDeltaTime)).ToString() + " FPS";
    }
}
