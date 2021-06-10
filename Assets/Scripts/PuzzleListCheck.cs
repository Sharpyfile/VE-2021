using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleListCheck : MonoBehaviour
{
    public List<BoxSnapCheck> checks = new List<BoxSnapCheck>();
    private bool puzzleCompleted = false;
    public GameObject objectToActivate;
    public bool action;

    // Update is called once per frame
    void Update()
    {
        bool snapCheck = true;
        foreach (BoxSnapCheck check in checks)
        {
            if (!check.isCorrect)
                snapCheck = false;
        }
        // test has passed, all objects are in place
        if (snapCheck)
        {
            // Do something, for now set object to be active (or not)
            objectToActivate.SetActive(action);
        }
    }
}
