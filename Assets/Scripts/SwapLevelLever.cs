using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwapLevelLever : MonoBehaviour
{
    public UnityEvent Event;

    // Update is called once per frame
    void Awake()
    {
        Event.Invoke();
    }
}
