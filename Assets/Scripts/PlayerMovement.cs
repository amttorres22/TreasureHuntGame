using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    float moveX, moveY, jumpUp;
   
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        jumpPower = 8;
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
