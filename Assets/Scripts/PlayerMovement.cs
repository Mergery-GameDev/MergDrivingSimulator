using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed= 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FORWARD MOTION 
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);



    }
}
