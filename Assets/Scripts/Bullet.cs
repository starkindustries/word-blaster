﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    public float speed = 20f;
    public Rigidbody2D rb;
    // public GameObject bulletParticles;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(this.gameObject, 3.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BULLET HIT: " + collision.gameObject.tag);
        // Instantiate(bulletParticles, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}