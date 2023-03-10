using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balldestroyer : MonoBehaviour
{

    [SerializeField] float count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

        {
            if (count > 10f)
            {
                count = 0;
                Destroy(gameObject);
                //count = 0;
            }

            count = count + 1 * Time.deltaTime;
        }
    }


}

