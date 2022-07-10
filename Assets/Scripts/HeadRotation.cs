using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    float mouseSpeed;
    float mouseX;



    void Start()
    {
        player = transform.parent.gameObject;
        mouseSpeed = 100f;
  
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        player.transform.Rotate(Vector3.up * mouseX);
    }
}
