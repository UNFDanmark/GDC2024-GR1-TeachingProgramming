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
    public int i;
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
        if (leftovercooldown <= 0 && i < 20)
        {
            float xspawn = Random.Range(xMin + transform.position.x, xMax + transform.position.x);
            float zspawn = Random.Range(zMin + transform.position.z, zMax + transform.position.z);
            Vector3 spawnPosition = new Vector3(xspawn, transform.position.y, zspawn);
            GameObject newEnemy = Instantiate(spawnObject, spawnPosition, Quaternion.identity);
            Enemy enemyscript = newEnemy.GetComponent<Enemy>();
            leftovercooldown = spawnCooldown;
            enemyscript.myspawner = this;
            i++;
        }
        
        
    }
    
    
}
