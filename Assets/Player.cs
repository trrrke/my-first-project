using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    public Rigidbody Rigidbody;
  //  public CharacterController controller;
    public class PlayerController : MonoBehaviour
    {
        public float JumpForce = 10f;
      // private Rigidbody Rigidbody;
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
       // Rigidbody = gameObject.GetComponent<Rigidbody>();
      //  controller = gameObject.GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("jump"))
        {
            Jump();
        }
       // float Horizontal = Input.GetAxis("Horizontal");
       // float Vertical = Input.GetAxis("Vertical");
       // Vector3 Movement = new Vector3(Horizontal, 1, Vertical);
       // Rigidbody.MovePosition(Rigidbody.position + Movement*5* Time.deltaTime);
    }
    void Jump()
    {
        Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, jumpForce , Rigidbody.velocity.z);
    }

}
