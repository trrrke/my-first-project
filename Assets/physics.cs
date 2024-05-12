using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnmyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform A;
    public Transform B;

    void Start()
    {
        transform.LookAt(A);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);

        
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.name == "A")
            transform.LookAt(B);
        else if (other.gameObject.name == "B")
        {
            transform.LookAt(A);
        }
    }

      
    
  
}
