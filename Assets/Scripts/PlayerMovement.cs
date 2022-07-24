using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jumpPower = 5;
    float moveX, moveY, jumpUp;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        jumpUp = Input.GetAxis("Jump");

        

        transform.Translate(moveX * speed * Time.deltaTime, jumpUp * jumpPower * Time.deltaTime, 
            moveY * speed * Time.deltaTime);
    }
}
