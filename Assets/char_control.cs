using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject body;
    public float speed=1;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        AimRotation();
        PlayerMovement();
    }
     void AimRotation()
    {
        if (true)
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
        if(true)
        {
            
           Vector3 direction = new Vector3((-1*Input.GetAxisRaw("Vertical")), 0, Input.GetAxisRaw("Horizontal")).normalized;

            if (direction.magnitude >= 0.1f)
            {
                 GetComponent<CharacterController>().Move(direction * speed * Time.deltaTime);                 
            }
            

        
        }
    }
}
