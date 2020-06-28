using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 50f;

    void Update()
    {
        float rotationSpeed = speed * Time.deltaTime;
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
    }
}
