using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletpefap;
    public float bulletspeed = 10;
    void Start()
    {
        
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            var bullet = Instantiate(bulletpefap, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
            //GameObject bullet = Instantiate(bulletpefap, gun.position, gun.rotation);
            //  bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        }
    }
}
