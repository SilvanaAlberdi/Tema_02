using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{
    private Vector3 initialPos;
    public float speed = 10f;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 48f;
    private float zRange = 23f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // OJO CON LAS MAYÚSCULAS
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // EL ORDEN ES X, Y, Z
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, - zRange);
        }
    }
}
