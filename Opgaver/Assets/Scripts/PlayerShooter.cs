using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private Transform transform;
    public float rotatespeed = 1f;
    public GameObject BulletPrefab;
    public float Cooldowntime = 0.3f;
    private float leftovercooldown;
    public float bulletspeed = 10f;
  
    
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        leftovercooldown = leftovercooldown - Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && leftovercooldown <= 0)
        {
            GameObject bullet =Instantiate(BulletPrefab, transform.position, quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = transform.forward * bulletspeed;
            leftovercooldown = Cooldowntime;
        }

        transform.Rotate(0,Input.GetAxisRaw("Turnaround")*rotatespeed,0);
        
        
        
        
    }
}
