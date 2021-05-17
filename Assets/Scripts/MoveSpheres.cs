using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpheres : MonoBehaviour
{
    Transform transform;
    float moved = 0;
    bool up = true;

    public float maxMoves = 100.0f;
    public float movementStep = 0.1f;
    public string coor = "z";

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
                transform.localPosition = transform.localPosition + new Vector3(0.0f, 0.0f, movementStep);
                moved += movementStep;

                if (Math.Abs(moved - maxMoves) < 0.01f)
                {
                    moved = 0;
                    up = false;
                }
            }
            else
            {
                transform.localPosition = transform.localPosition - new Vector3(0.0f, 0.0f, movementStep);
                moved += movementStep;

                if (Math.Abs(moved - maxMoves) < 0.01f)
                {
                    moved = 0;
                    up = true;
                }
            }
        } else if (coor.Equals("x"))
        {
            if (up)
            {
                transform.localPosition = transform.localPosition + new Vector3(movementStep, 0.0f, 0.0f);
                moved += movementStep;

                if (Math.Abs(moved - maxMoves) < 0.01f)
                {
                    moved = 0;
                    up = false;
                }
            }
            else
            {
                transform.localPosition = transform.localPosition - new Vector3(movementStep, 0.0f, 0.0f);
                moved += movementStep;

                if (Math.Abs(moved - maxMoves) < 0.01f)
                {
                    moved = 0;
                    up = true;
                }
            }
        }

    }
}
