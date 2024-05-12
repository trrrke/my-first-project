using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDor : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(MoveHorizontal, 0 , moveVertical);
        rb.AddForce(Movement * speed);
    }
}
