using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xrotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float zrotation = Input.GetAxis("Perspective") * rotationSpeed;

        xrotation *= Time.deltaTime;
        zrotation *= Time.deltaTime;

        transform.Rotate(xrotation, 0, 0);
        transform.Rotate(0, 0, zrotation);
    }
}
