using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        print("collision" + other.gameObject.tag);
        if (other.gameObject.CompareTag("Target"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}