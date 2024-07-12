using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private Transform transform;
    public float rotatespeed = 10f;

    
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Input.GetAxisRaw("Turnaround")*rotatespeed,0);
    }
}
