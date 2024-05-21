// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class shooter : MonoBehaviour
// {
//     public GameObject fire;
//     int count = 1;
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {


//         if (Input.GetKey(KeyCode.LeftArrow))

//         {
//             GetComponent<Animator>().SetInteger("Mode", 1);
//             if (transform.position.x > -8.5f)
//             {
//                 transform.position -= new Vector3(10 * Time.deltaTime, 0, 0);
//             }
//             // if (Input.GetKey(KeyCode.Space))
//             // {

//             //     shouting();
//             // }
//             //  GetComponent<Rigidbody2D>().AddForce(Vector2.left * 700);

//         }
//         else if (Input.GetKey(KeyCode.RightArrow))

//         {
//             GetComponent<Animator>().SetInteger("Mode", -1);
//             if (transform.position.x < 8.5f)
//             {
//                 transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
//             }
//             // if (Input.GetKey(KeyCode.Space))
//             // {

//             //     shouting();
//             // }
//             //GetComponent<Rigidbody2D>().AddForce(Vector2.right * 700);
//         }
//         else if (Input.GetKey(KeyCode.Space))
//         {

//             shouting();
//         }
//         else
//         {
//             GetComponent<Animator>().SetInteger("Mode", 0);

//         }

//         // if (Input.GetKeyUp(KeyCode.LeftArrow) && !(Input.GetKeyDown(KeyCode.RightArrow)) )

//         // {
//         //     GetComponent<Animator>().SetInteger("Mode", 0);
//         //     GetComponent<Rigidbody2D>().velocity = Vector2.zero;
//         // }


//         // if (Input.GetKeyUp(KeyCode.RightArrow) && !(Input.GetKeyDown(KeyCode.LeftArrow)) )
//         // {
//         //    GetComponent<Animator>().SetInteger("Mode", 0);
//         //     GetComponent<Rigidbody2D>().velocity = Vector2.zero;
//         // }
//     }
//     public void shouting()
//     {
//         GetComponent<Animator>().SetInteger("Mode", 2);
//         GameObject bullet = Instantiate(fire, GameObject.Find("postion").transform.position, Quaternion.identity);
//         bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 600);
//         Destroy(bullet, 2f);
//         print("hello");
//         count++;
//         print(count);
//         StartCoroutine(ShootWithDelay(1000f));

//         }

//         IEnumerator ShootWithDelay(float delay)
//         {
//         yield return new WaitForSeconds(delay);

//         // Code to execute after the delay
//         // Add your shooting logic here
//         }

//     }

using System.Collections;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject fire;
   
    private bool isShooting = false;
    private Coroutine shootingCoroutine;

    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
       // Handle movement
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        MoveLeft();
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        MoveRight();
    }
    else
    {
        Idle();
    }

    // Handle shooting
    if (Input.GetKey(KeyCode.Space))
    {
        StartShooting();
    }
    else
    {
        StopShooting();
    }
}

void MoveLeft()
{
    GetComponent<Animator>().SetInteger("Mode", 1);
    if (transform.position.x > -8.5f)
    {
        transform.position -= new Vector3(10 * Time.deltaTime, 0, 0);
    }
}

void MoveRight()
{
    GetComponent<Animator>().SetInteger("Mode", -1);
    if (transform.position.x < 8.5f)
    {
        transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
    }
}

void Idle()
{
    GetComponent<Animator>().SetInteger("Mode", 0);
}

void StartShooting()
{
    if (!isShooting)
    {
        isShooting = true;
        shootingCoroutine = StartCoroutine(ShootRepeatedly(1f));
    }
}

void StopShooting()
{
    if (isShooting)
    {
        StopCoroutine(shootingCoroutine);
        isShooting = false;
    }
    }

    private IEnumerator ShootRepeatedly(float interval)
    {
        while (true)
        {
            shouting();
            yield return new WaitForSeconds(interval);
        }
    }

    public void shouting()
    {   GameObject.Find("laserShoot").GetComponent<AudioSource>().Play();
        GetComponent<Animator>().SetInteger("Mode", 2);
        GameObject bullet = Instantiate(fire, GameObject.Find("postion").transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 600);
        Destroy(bullet, 2f);
    

    
    }
}

