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

    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject element = Instantiate(spiralElement, transform);
        }
    }

    void Update()
    {
        for (int i = 0; i < amount; i++)
        {
            Transform elementTransform = transform.GetChild(i);
            elementTransform.localPosition = new Vector3(
                Mathf.Cos(i + Time.time * Mathf.PI * 2 * speedX) * amplitudeX,
                Mathf.Sin(i + Time.time * Mathf.PI * 2 * speedY) * amplitudeY,
                0);
        }

       
    }
}
