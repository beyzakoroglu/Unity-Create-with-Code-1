using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    private int controller = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        if(controller != 0)
        {
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed);
        }



        if(verticalInput != 0)
        {
            controller = 1;
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * (-verticalInput) * rotationSpeed * Time.deltaTime);
        }
    }
}
