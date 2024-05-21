using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class enemy_generator : MonoBehaviour

{ float drag = 10 ;
  public GameObject bee;
  public float timer;
  float time_count = 2;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    timer += 1 * Time.deltaTime;
    if (timer > time_count)
    {
      timer = 0;
      control_enemy();
      count_control();

    }


  }
  void control_enemy()
  {
    GameObject b = Instantiate(bee, new Vector3(Random.Range(-8, 8), 6, 0), Quaternion.identity);
    
    // b.GetComponent<Rigidbody2D>().AddForce(Vector2.down*300*delt);
      b.GetComponent<Rigidbody2D>().drag = drag;
      drag -= 0.2f;
  }
  void count_control()
  {
   // print(time_count);
    if (time_count > 0.5)
    {
      time_count -= (float)(Time.deltaTime / 0.5);

      time_count = Mathf.Max(time_count, 0.5f);
    }
  }
  void control_speed()
  {
    
  }
}
