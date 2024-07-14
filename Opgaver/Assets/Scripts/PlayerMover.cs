using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float Speed = 10f;

    public Animator animator;
    private Rigidbody rb;
    public GameObject gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hej jeg er player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal")*Speed;
        move.z = Input.GetAxisRaw("Vertical")*Speed;
        rb.velocity = move;
        
        animator.SetFloat("Speed",move.magnitude);
        
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.SetActive(true);
        }
    }
    
}

