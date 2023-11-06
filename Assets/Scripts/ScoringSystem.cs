using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem: MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;


    void OnTriggerEnter(Collider other)
    {
        theScore += 50;
        
        Destroy(gameObject);
    }

}
