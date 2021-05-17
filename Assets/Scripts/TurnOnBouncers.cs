using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnBouncers : MonoBehaviour
{
    public GameObject lightObj;

    private Light light;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        light = lightObj.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 0)
        {
            light.intensity = 0f;
        }
        else
        {
            i--;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        light.intensity = 2f;
        i = 150;
    }
}
