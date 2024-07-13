using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MøntSpawner : MonoBehaviour
{
    public float spawnCooldown = 6f;
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    
    private float leftovercooldown;
    public GameObject MøntPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        leftovercooldown = spawnCooldown;
        Instantiate(MøntPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        leftovercooldown = leftovercooldown - Time.deltaTime;
        if (leftovercooldown <= 0)
        {
            float xspawn = Random.Range(xMin + transform.position.x, xMax + transform.position.x);
            float zspawn = Random.Range(zMin + transform.position.z, zMax + transform.position.z);
            Vector3 spawnPosition = new Vector3(xspawn, transform.position.y, zspawn);
            Instantiate(MøntPrefab, spawnPosition, Quaternion.identity);
            leftovercooldown = spawnCooldown;
        }
        
    }
}
