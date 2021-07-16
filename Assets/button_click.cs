using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_click : MonoBehaviour
{
public Canvas parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shrink()
    {
      parent.transform.localScale=new Vector3(0,0,0);
    }
}
