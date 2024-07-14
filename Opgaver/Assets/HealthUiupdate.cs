using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUiupdate : MonoBehaviour
{

    private PlayerMover pM;
    
    
    // Start is called before the first frame update
    void Start()
    {
        pM = GameObject.FindWithTag("Player").GetComponent<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pM.hasbeenattacked)
        {
            
        }
    }
}
