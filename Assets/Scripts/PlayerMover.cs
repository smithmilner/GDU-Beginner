using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 10f;

    private CollisionDamage collisionDamage;

    private void Start() {
        collisionDamage = GetComponent<CollisionDamage>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!collisionDamage.isDead) {
            float moveX = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(moveX * speed * Time.deltaTime, 0, 0));
        }
    }
}
