using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebuttons : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public float Force;

    public void moveRight()
    {
      
        player.transform.Translate(Force * Time.deltaTime, 0 , 0);
        Debug.Log("right");


    }

    public void moveLeft() 
    {
        

    }


}
