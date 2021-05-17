using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWorldLightOn : MonoBehaviour
{
    public string inputName = "FJ";

    private Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(inputName[0].ToString()) == 1 || Input.GetAxis(inputName[1].ToString()) == 1)
        {
            light.intensity = 2f;
        }
        else
        {
            light.intensity = 0.5f;
        }
    }
}
