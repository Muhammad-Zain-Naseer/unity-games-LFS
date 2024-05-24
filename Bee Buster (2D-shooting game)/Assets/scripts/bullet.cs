using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
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
        if (other.name != "shooter" && other.name != "left_side" && other.name != "right_side")
        {
            GameObject.Find("manager").GetComponent<manager>().score += 1;
            int random = Random.Range(1, 5);
           
            GameObject.Find("D_" + random).GetComponent<AudioSource>().Play();
            GameObject.Find("manager").GetComponent<manager>().save();


            Destroy(other.gameObject);
        }


    }

}