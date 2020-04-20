using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float bulletSpeed;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // print("Bang!");

        // instantiate the bullet
        GameObject projectile = Instantiate(projectilePrefab);

        // get the bullets rigidbody
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        // add velocity to the rigidbody
        rb.velocity = transform.forward * bulletSpeed;
    }
}