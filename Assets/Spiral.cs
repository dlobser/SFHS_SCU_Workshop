using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{

    public GameObject spiralElement;
    public int amount = 100;
    
    GameObject[] elements;

    public float rotate = 10;
    public float speed = 0.05f;
    public float spread = .05f;
    public float zDepth = -.1f;

    void Start()
    {
        if(spiralElement==null){
            spiralElement = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
        elements = new GameObject[amount];
        for (int i = 0; i < amount; i++)
        {
            elements[i] = Instantiate(spiralElement);
        }
    }

    void Update()
    {
        for (int i = 0; i < amount; i++)
        {
            elements[i].transform.localPosition = new Vector3(
                Mathf.Sin(Time.time*speed*(amount-i)*.1f+rotate*i*.1f)*spread*i,
                Mathf.Cos(Time.time*speed*(amount-i)*.1f+rotate*i*.1f)*spread*i,
                i*zDepth
            );
        }
    }
}
