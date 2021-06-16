using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float audioStart = 0.03f;
    void Awake()
    {
        if (animator.TryGetComponent(out AudioSource source))
        {
            source.time = audioStart;
            source.Play();
        }
            
        animator.Play("Open");
    }
}
