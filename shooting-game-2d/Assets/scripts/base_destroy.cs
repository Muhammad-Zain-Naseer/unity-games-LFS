using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_destroy : MonoBehaviour
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
        if (other.name == "enemy" || other.name == "enemy(Clone)")
        {
           

            Destroy(other.gameObject);


          //  UnityEditor.EditorApplication.isPlaying = false;

        }
    }
}
