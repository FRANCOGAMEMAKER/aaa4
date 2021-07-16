using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject body;
    public float speed=1;

    public GameObject boom;
    public GameObject boom_spawn;
    public bool is_interact=false;
    GameObject theinterac_canvas;

    Quaternion og_rotation;
    void Start()
    {
        og_rotation=body.transform.rotation;
      theinterac_canvas=GameObject.Find("thecanvas");
    }

    // Update is called once per frame
    void Update()
    {
        AimRotation();
        PlayerMovement();
        Shoot();
        
    }
     void AimRotation()
    {
        if (is_interact==false)
        {
            Vector3 positionOnScreen = Camera.main.WorldToViewportPoint(body.transform.position);
            Vector3 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

            Vector3 direction = mouseOnScreen - positionOnScreen;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;
            body.transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
        }
    }
    void PlayerMovement()
    {
        if(is_interact==false)
        {
            
           Vector3 direction = new Vector3((-1*Input.GetAxisRaw("Vertical")), 0, Input.GetAxisRaw("Horizontal")).normalized;

            if (direction.magnitude >= 0.1f)
            {
                 GetComponent<CharacterController>().Move(direction * speed * Time.deltaTime);                 
            }
            

        
        }
    }
    void Shoot()
    {
        if(is_interact==false)
        {
        
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(boom, boom_spawn.transform.position, boom_spawn.transform.rotation);
                
            }

           
        
    }

    
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.tag=="interact")
        {
            is_interact=true;
             transform.LookAt(other.gameObject.transform.position);
             theinterac_canvas.transform.localScale=new Vector3(1,1,1);

        }
    }
void checkUIstate()
{
if(is_interact)
{
    if(theinterac_canvas.transform.localScale.magnitude<=0.1f)
    {
is_interact=false;
transform.rotation=og_rotation;
    }
}
}
    

}
