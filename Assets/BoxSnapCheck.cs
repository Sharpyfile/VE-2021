using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSnapCheck : MonoBehaviour
{
    public string PuzzleSolution;
    public bool isCorrect = false; 

    // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GrabObject")
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().Sleep();
            if (other.TryGetComponent<PuzzleObject>(out PuzzleObject puzzleObject))
            {
                if(puzzleObject.PuzzleSolution == PuzzleSolution)
                {
                    isCorrect = true;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "GrabObject")
        {
            if (other.TryGetComponent<PuzzleObject>(out PuzzleObject puzzleObject))
            {
                if(puzzleObject.PuzzleSolution == PuzzleSolution)
                {
                    isCorrect = false;
                }
            }
        }
    }
}
