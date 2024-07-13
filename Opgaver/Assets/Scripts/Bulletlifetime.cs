using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlifetime : MonoBehaviour
{
    public float lifetime = 5f;
    public float timeleft;
    
     
    // Start is called before the first frame update
    void Start()
    {
        timeleft = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;
        DestroyBullets();
    }

    void DestroyBullets()
    {
        if (timeleft<=0)
        {
            Destroy(gameObject);
        }
        
    }
    
    
}
