using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager: MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnDelay = 2;
    private float repeatRate = 2;

    private Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, repeatRate);
        playerScript = GameObject.Find("Player").GetComponent<Player>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        //if (!playerScript.gameOver)
        {   
            
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }
}