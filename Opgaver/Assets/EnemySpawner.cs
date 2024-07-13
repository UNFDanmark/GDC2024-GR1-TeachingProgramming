using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnCooldown = 6f;
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    
    private float leftovercooldown;
    public GameObject spawnObject; 
    // Start is called before the first frame update
    void Start()
    {
        leftovercooldown = spawnCooldown;
        Instantiate(spawnObject, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        leftovercooldown = leftovercooldown - Time.deltaTime;
        if (leftovercooldown <= 0)
        {
            float xspawn = Random.Range(xMin, xMax);
            float zspawn = Random.Range(xMin, xMax);
            Vector3 spawnPosition = new Vector3(xspawn, transform.position.y, zspawn);
            Instantiate(spawnObject, spawnPosition, Quaternion.identity);
            leftovercooldown = spawnCooldown;
        }
        
    }
}
