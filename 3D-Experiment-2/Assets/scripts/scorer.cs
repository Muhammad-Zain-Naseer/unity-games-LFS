using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.tag != "Hit")
        {
            score++;

            Debug.Log("You've bumped into a thing this many times: " + score);
        }
    }
}
