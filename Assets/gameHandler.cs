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

    private void Start()
    {
        slider.maxValue = healthSystem.gethealth();
    }
    // Start is called before the first frame update
    public void Update()
    {
        slider.value = healthSystem.gethealthpercentage();
    }
    private void OnTriggerEnter(Collider other)
    {
        healthSystem.Damage(10);
         if (other.gameObject.tag == "enemy") {
            Debug.Log("Heyyyyy");
            healthSystem.Damage(10); }
        if (other.gameObject.tag == "heal") {
            Debug.Log("Heyyyyy"); 
            healthSystem.heal(10); }
    }


    // Update is called once per frame

}
