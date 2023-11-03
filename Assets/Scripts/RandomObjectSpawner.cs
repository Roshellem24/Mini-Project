using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner: MonoBehaviour
{
    public GameObject[] myObjects;
    public float speed = 10.0f;
    private Rigidbody rb;

    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }

    }
}