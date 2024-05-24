using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droper : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float time = 5f;
  new  MeshRenderer renderer;
  new  Rigidbody rigidbody;
    void Start()
    {
            renderer = GetComponent<MeshRenderer>();
            rigidbody = GetComponent<Rigidbody>();
            renderer.enabled = false;
            rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
