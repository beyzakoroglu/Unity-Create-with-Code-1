using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  //-1, 0 or 1
        forwardInput = Input.GetAxis("Vertical");  //-1, 0 or 1
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * turnSpeed);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);   //(axis, angle)
    }
}
