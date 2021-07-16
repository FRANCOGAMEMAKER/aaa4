using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_detect : MonoBehaviour
{
    public bool passed=false;
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
        if(other.tag=="Player")
        {
passed=true;
        }
    }
}
