using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public Color deathColor;
    public GameObject deathMessage;

    [HideInInspector]
    public bool isDead = false;

    private Rigidbody rb;
    private AudioSource impact;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        impact = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            deathMessage.SetActive(true);
            isDead = true;
            impact.Play();
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }

}
