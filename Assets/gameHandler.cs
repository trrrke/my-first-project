using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public Slider slider;
    HelathSystem healthSystem = new HelathSystem(100);
    // Start is called before the first frame update
    public void Update()
    {
        slider.value = healthSystem.gethealthpercentage();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "enemy") { healthSystem.Damage(10); }
        if (other.gameObject.tag == "heal") {  healthSystem.heal(10); }
    }
    void Start()
    {
        
    }

    // Update is called once per frame

}
