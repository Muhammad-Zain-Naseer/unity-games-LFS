using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] float xValue = 0;
      [SerializeField] float yValue = 0;
       [SerializeField] float zValue = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue,yValue,zValue);
    }
}
