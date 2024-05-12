using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpniner : MonoBehaviour
{
    public Transform door;
    public Vector3 closedPosition = new Vector3 (.50f, 3.66f, 0);
    public Vector3 openedPosition = new Vector3(.51f, 7, 0);

    public float openspeed = 6;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            door.position = Vector3.Lerp(door.position, openedPosition, Time.deltaTime * openspeed);
        }
        else
        { 
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openspeed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoor();
        }
    }
    private void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CloseDoor();
        }
    }
    public void CloseDoor()
    {
        open = false;
    }
    public void OpenDoor()
    {
        open = true;
    }
}
