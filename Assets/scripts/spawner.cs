using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ball;

   public void buttonPress()
    {
        Instantiate(ball);
    }
    
}
