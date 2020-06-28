using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public System.DateTime startTime;
    public int destroyCountdown = 5;

    // Start is called before the first frame update
    void Start()
    {
        startTime = System.DateTime.UtcNow;
    }

    // Update is called once per frame
    void Update()
    {
        System.TimeSpan ts = System.DateTime.UtcNow - startTime;

        if (ts.Seconds > destroyCountdown) {
            Destroy(gameObject);
        }
    }
}
