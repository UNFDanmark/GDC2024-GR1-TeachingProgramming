using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal;

public class Enemy : MonoBehaviour
{
    public int Speed = 20;
    public float Cooldown = 20.3f;

    private NavMeshAgent agent;
    private Transform playerTransform;
    public Animator animator;
    public EnemySpawner myspawner;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindWithTag("Player").transform;
        agent.destination = playerTransform.position;
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullets"))
        {
            Destroy(other.gameObject);
            myspawner.i--;
            Destroy(gameObject);
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerTransform.position; 
        animator.SetFloat("Speed",agent.velocity.magnitude);
    }
}
