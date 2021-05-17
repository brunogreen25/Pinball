using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : MonoBehaviour
{
    public GameObject lightObj;
    public string inputName;

    private Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = lightObj.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(inputName) == 1)
        {
            light.intensity = 1.5f;
        }
        else
        {
            light.intensity = 0f;
        }
    }
}
