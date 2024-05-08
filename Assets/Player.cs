using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("jumpForce"))
        {
            rigidbody.AddForce(Vector3.up * jumpForce);
            Debug.Log("hello");
        }
    }
}

