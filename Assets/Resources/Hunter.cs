using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    // Start is called before the first frame update
    float rotate_factor;
    void Start()
    {
        rotate_factor = 12;
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime;
        transform.Rotate(new Vector3(0, Time.deltaTime*rotate_factor, 0));
    }
}
