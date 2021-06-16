using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReflectionTexture : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plane;
    public Camera reflectionCamera;
    public GameObject player;
    public float distance;

    // Update is called once per frame
    void Start()
    {
        int oldMask = reflectionCamera.cullingMask;
        reflectionCamera.cullingMask = ~(1 << LayerMask.NameToLayer("Water"));
        reflectionCamera.gameObject.SetActive(false);
    }

    void Update()
    {
        
        if (Vector3.Distance(plane.transform.position, player.transform.position) > distance && reflectionCamera.gameObject.activeSelf)
        {
            reflectionCamera.gameObject.SetActive(false);
            plane.SetActive(false);
        }
            
        else if (Vector3.Distance(plane.transform.position, player.transform.position) < distance && !reflectionCamera.gameObject.activeSelf)
        {
            reflectionCamera.gameObject.SetActive(true);
            plane.SetActive(true);
        } 
            
    }
}