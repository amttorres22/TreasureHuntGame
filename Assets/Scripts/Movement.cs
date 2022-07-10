using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedX;
    public float speedZ;


    // Start is called before the first frame update
    void Start()
    {
        speedX = 0.09f;
        speedZ = 0.045f;
        
        
    }

    // Update is called once per frame

    //boundary of plane is +/-5 along the XZ axis
    void Update()
    {
        //if nearing bounds, move in opposite direction
        if (transform.position.x > 4 || transform.position.x < -4)
        {
            speedX *= -1;
        }
        if (transform.position.x > 4 || transform.position.x < -4)
        {
            speedZ *= -1;
        }




        transform.Translate(speedX, 0, speedZ);
    }
}
