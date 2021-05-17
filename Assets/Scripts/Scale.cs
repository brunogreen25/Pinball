using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scale : MonoBehaviour
{
    Transform transform;
    float scaled = 0;
    bool up = true;

    public float maxScale = 10.0f;
    public float scalingStep = 0.1f;
    public string coor = "xz";

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        coor = coor.ToLower();
    }


    // Update is called once per frame
    void Update()
    {
        if (coor.Equals("z"))
        {
            if (up)
            {
                transform.localScale = transform.localScale + new Vector3(0.0f, 0.0f, scalingStep);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = false;
                }
            }
            else
            {
                transform.localScale = transform.localScale - new Vector3(0.0f, 0.0f, scalingStep);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = true;
                }
            }
        }
        else if (coor.Equals("x"))
        {
            if (up)
            {
                transform.localScale = transform.localScale + new Vector3(scalingStep, 0.0f, 0.0f);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = false;
                }
            }
            else
            {
                transform.localScale = transform.localScale - new Vector3(scalingStep, 0.0f, 0.0f);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = true;
                }
            }
        }
        else if (coor.Equals("xz") || coor.Equals("zx"))
        {
            if (up)
            {
                transform.localScale = transform.localScale + new Vector3(scalingStep, 0.0f, scalingStep);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = false;
                }
            }
            else
            {
                transform.localScale = transform.localScale - new Vector3(scalingStep, 0.0f, scalingStep);
                scaled += scalingStep;

                if (Math.Abs(scaled - maxScale) < 0.01f)
                {
                    scaled = 0;
                    up = true;
                }
            }
        }

    }
}
