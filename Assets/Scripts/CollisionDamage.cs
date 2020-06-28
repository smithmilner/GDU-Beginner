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

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            deathMessage.SetActive(true);
            isDead = true;
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }

}
