using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float upthrust = 100f;
    [SerializeField] float rotationthrust = 100f;
    Rigidbody rb;
    AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Processupthrust();
        Processrotation();
    }
    void Processupthrust()
    {
        if (Input.GetKey(KeyCode.Space))


        {
            if (!audioSource.isPlaying)
                audioSource.Play();
            rb.AddRelativeForce(Vector3.up * upthrust * Time.deltaTime); // 0,1,0
            //audioSource.Stop();
        }

    }
    void Processrotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(rotationthrust); // 0,0,1
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(-rotationthrust);// 0,0,-1
        }
    }

    void ApplyRotation(float rotationthrustframe)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationthrustframe * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
