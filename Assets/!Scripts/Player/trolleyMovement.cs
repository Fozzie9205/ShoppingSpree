using UnityEngine;
using System.Collections;

public class trolleyMovement : MonoBehaviour
{
    public float speed = 750;
    public float rotateSpeed = 300;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //moving forward
        {
            speed = 750;
            rb.AddForce(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) //moving backward
        {
            speed = 500;
            rb.AddForce(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) //turn right
        {
            transform.Rotate(0, 0.5f * rotateSpeed * Time.deltaTime, 0);
        }
           
        if (Input.GetKey(KeyCode.A)) //turn left
        {
            transform.Rotate(0, -0.5f * rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.W)) //plays audio when W is held
        {
            Audios.TrolleyPlay();
        }

        if (Input.GetKeyUp(KeyCode.W)) //stops audio when W is released
        {
            Audios.TrolleyStop();
        }

        if (Input.GetKey(KeyCode.R)) //resets Players rotation
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}