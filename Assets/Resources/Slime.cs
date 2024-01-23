using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 scale;
    private float time;
    float distance;
    float rotational_period_factor;
    // Start is called before the first frame update
    void Start()
    {
        origin = new Vector3(0, 1, 0);
        time = 0;
        distance = 10;
        rotational_period_factor = 0.2f;
        scale = new Vector3(3, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.position = origin + new Vector3(distance*Mathf.Sin(rotational_period_factor*time), Mathf.Pow(Mathf.Sin(time),2), distance*Mathf.Cos(rotational_period_factor*time));
        transform.localScale = scale + new Vector3(0, Mathf.Pow(Mathf.Sin(time),2), 0);
    }
}
