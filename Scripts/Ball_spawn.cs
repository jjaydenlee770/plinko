using UnityEngine;
using System.Collections;


public class Ball_spawn : MonoBehaviour
{
    public GameObject ball_spawner;
    public GameObject ball;
    private WaitForSeconds wait = new WaitForSeconds(2f);

    public bool start_ball = false;
    void Update()
    {
        if (start_ball == true)
        {
             Instantiate(ball,ball_spawner.transform.position, Quaternion.identity);
             start_ball = false;
        }
      
    }
  
}
