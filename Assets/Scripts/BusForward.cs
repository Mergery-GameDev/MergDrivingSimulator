using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusForward : MonoBehaviour
{
    public float busSpeed= 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* busSpeed* Time.deltaTime);
        
    }
}
