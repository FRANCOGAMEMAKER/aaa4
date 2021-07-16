using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_cont : MonoBehaviour
{
    public wall_detect wall;
    public GameObject face;
    // Start is called before the first frame update
    void Start()
    {
        wall=GameObject.Find("wall").GetComponent<wall_detect>();
    }

    // Update is called once per frame
    void Update()
    {
       Invoke("angry",0.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="boom")
        {
         Destroy(this.gameObject);
        }
    }

    void angry()
    {
 if(wall.passed)
        {
             face.transform.localScale=new Vector3(1,1,1);
        }
    }

   
    
}
