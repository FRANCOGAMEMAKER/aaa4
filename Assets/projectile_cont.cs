using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_cont : MonoBehaviour
{
    public float speed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.localPosition+=this.gameObject.transform.right*Time.deltaTime* speed;
    }
    private void OnTriggerEnter(Collider other)
    {
         Destroy(this.gameObject,0.1f);
    }
   
}
