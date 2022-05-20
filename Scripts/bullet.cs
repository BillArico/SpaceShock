using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D rb2d;
    public int Edamage = -50;
    // impact effects
    //public GameObject impactEffect;

    void Start()
    {
        rb2d.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(Edamage);
        }
        //Instantiate(impactEffect,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
