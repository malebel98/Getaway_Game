using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletP;
    public Transform bulletS;
    //public float shoot = 0.3f;
    //private float Stime;



    void Fire()
    {
        var bulletClone = (GameObject)Instantiate(bulletP, bulletS.position, bulletS.rotation);
        bulletClone.GetComponent<Rigidbody>().velocity = bulletClone.transform.forward * 60;
        Destroy(bulletClone, 2.0f);
    }

    void Update()
    {
        if (Input.GetButtonDown("Shoot")) //&& Time.time > Stime)
        {
            //Stime = Time.time + shoot;
            Fire();
        }
    }
}
