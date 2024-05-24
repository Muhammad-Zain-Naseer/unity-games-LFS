using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{


    [SerializeField] float xValue = 0;
    [SerializeField] float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        instructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
    void instructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with the arrow keys or WASD");
        Debug.Log("Avoid hitting walls");
    }
    void movePlayer()
    {

        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(zValue, xValue, yValue);
    }
}
