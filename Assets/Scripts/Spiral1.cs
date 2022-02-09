using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral1 : MonoBehaviour
{

    public GameObject spiralElement;
    public int amount = 100;
    
    GameObject[] elements;

    public float rotate = 10;
    public float speed = 0.05f;
    public float spread = .05f;
    public float zDepth = -.1f;

    float HRV;

    List<float> HRVScale;

    void Start()
    {
        HRVScale = new List<float>();

        if(spiralElement==null){
            spiralElement = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
        elements = new GameObject[amount];
        for (int i = 0; i < amount; i++)
        {
            elements[i] = Instantiate(spiralElement);
            HRVScale.Add(.1f);
        }
    }

    void Update()
    {
        HRV = Input.mousePosition.y/Screen.height;
        HRVScale.Add(HRV);
        HRVScale.RemoveAt(0);

        for (int i = 0; i < amount; i++)
        {
            elements[i].transform.localPosition = new Vector3(
                Mathf.Sin(Time.time*speed*(amount-i)*.1f+rotate*i*.1f)*spread*i,
                Mathf.Cos(Time.time*speed*(amount-i)*.1f+rotate*i*.1f)*spread*i,
                i*zDepth
            );
            elements[i].transform.localScale = Vector3.one*HRVScale[i];
            Color HRVColor = Color.HSVToRGB(HRVScale[i],1,1);
            elements[i].GetComponent<MeshRenderer>().material.color = HRVColor;
        }
    }
}
