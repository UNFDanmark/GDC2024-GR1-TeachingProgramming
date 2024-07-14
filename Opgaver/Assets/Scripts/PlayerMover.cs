using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float Speed = 10f;

    public Animator animator;
    private Rigidbody rb;
    public GameObject gameOverScreen;
    public float MaxHealth = 50f;
    public float currenthealth;
    public float attackedCooldown = 0.5f;
    public float currentattackedCooldown;
    public bool hasbeenattacked = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hej jeg er player");
        rb = GetComponent<Rigidbody>();
        currenthealth = MaxHealth ;
        currentattackedCooldown = attackedCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal")*Speed;
        move.z = Input.GetAxisRaw("Vertical")*Speed;
        rb.velocity = move;
        
        animator.SetFloat("Speed",move.magnitude);


        if (currenthealth <= 0f)
        {
            gameOverScreen.SetActive(true);
        }
        currentattackedCooldown -= Time.deltaTime;
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            
            if (currentattackedCooldown <= 0f)
            {
                currenthealth--;
                currentattackedCooldown = attackedCooldown;
                hasbeenattacked = true;
            }
            
        }
    }
    
}

