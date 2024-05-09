using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce = 10f;
    public AudioManger audioManger;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("jump"))

        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            audioManger.PlayPlayerjump();
        }

    }
}