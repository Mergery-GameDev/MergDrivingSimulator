using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed= 15.0f;
    public float turnSpeed = 10.0f;
    public GameObject mainCamera;
    public GameObject driverCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //FORWARD MOTION 
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime * verticalInput);

        // TURN MOVEMENT 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
        
        }



    }
}
