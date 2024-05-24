using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != "base" && other.name != "left_side" && other.name != "right_side" && other.name != this.name)
        {
            Destroy(other.gameObject);

            if (other.name != "bullet" && other.name != "bullet(Clone)" && other.name != this.name) 
            {
                //print(other.name);
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
}
