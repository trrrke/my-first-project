using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

[Serializable]
public class HelathSystem : MonoBehaviour
{
    private float helathPoints;
    private float maxhelath;
    // Start is called before the first frame update
    public HelathSystem(int maxhelath)
    {
        this.maxhelath = maxhelath;
        helathPoints = maxhelath;
    }
    public float gethealth() { return helathPoints; }
    public float gethealthpercentage() { return helathPoints / maxhelath; }
    public void Damage(int DamageAmont)
    {
        helathPoints -= DamageAmont;
        if (helathPoints <= 0) {helathPoints = 0;}
    }
    public void heal(int healAmont)
    {
        helathPoints += healAmont;
        if (helathPoints > maxhelath) { helathPoints = maxhelath;}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
