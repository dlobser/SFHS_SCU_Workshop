using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit2 : MonoBehaviour
{
    public GameObject spiralElement;
    public int amount;

    public float speedX = 1;
    public float speedY = 1;

    public float amplitudeX = 1;
    public float amplitudeY = 1;

    public bool rebuildOnStart = false;

    void Start()
    {
       if(rebuildOnStart){
           Rebuild();
       }
    }

    public void Rebuild(){
        for (int i = 0; i < amount; i++)
        {
            GameObject element = Instantiate(spiralElement, transform);
            if(element.GetComponent<Orbit2>()!=null){
                element.GetComponent<Orbit2>().Rebuild();
            }
        }
    }

    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform elementTransform = transform.GetChild(i);
            float offset = ((float)i/(float)amount) * Mathf.PI * 2;
            elementTransform.localPosition = new Vector3(
                Mathf.Cos(offset + Time.time * Mathf.PI * 2 * speedX) * amplitudeX,
                Mathf.Sin(offset + Time.time * Mathf.PI * 2 * speedY) * amplitudeY,
                0);
        }

       
    }
}
