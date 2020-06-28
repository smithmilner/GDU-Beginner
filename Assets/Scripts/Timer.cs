using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private UnityEngine.UI.Text text;
    public CollisionDamage collisionDamage;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!collisionDamage.isDead) {
            text.text = Time.timeSinceLevelLoad.ToString("F2");
        }
    }
}
