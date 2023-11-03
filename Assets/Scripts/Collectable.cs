using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collectible : MonoBehaviour
{
   ScoreManager scoreManager;


    void start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore();
            gameObject.SetActive(false);
        }
    }
}
