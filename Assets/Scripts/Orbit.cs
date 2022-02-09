using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public string hi;
    int counter = 0;
    public float speed = 1;
    public Vector3 position;

    void Start()
    {

    }

    void Update()
    {
        this.transform.localPosition = new Vector3(
            position.x + Mathf.Cos(Time.time * Mathf.PI * 2 * speed),
            position.y + Mathf.Sin(Time.time * Mathf.PI * 2 * speed),
            position.z);
    }
}
