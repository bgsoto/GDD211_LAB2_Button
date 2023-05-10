using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        // For testing purposes only
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseScore(10);
        }

        */




        
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    private void OnCollisionEnter(Collision collision)
    
        
    
    {
        if (collision.gameObject.CompareTag("ball")) {



            if (this.gameObject.CompareTag("goal1")) { 
                    Destroy(collision.gameObject);
                    IncreaseScore(20);
                }

            if (this.gameObject.CompareTag("goal2")) { 
                    Destroy(collision.gameObject);
                    IncreaseScore(30);

                }
            else 
                 {
                Destroy(collision.gameObject);
                IncreaseScore(10);
                }

        }


    }



}
