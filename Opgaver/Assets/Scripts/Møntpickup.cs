using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Møntpickup : MonoBehaviour
{
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        i++;
    }
    
}
