using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    private HingeJoint hinge;
    public string inputName;

    private float pressedPosition;
    private float strength;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

        if (inputName.Equals("F"))
        {
            pressedPosition = -45f;
            strength = 8000f;
        } else if (inputName.Equals("J"))
        {
            pressedPosition = 45f;
            strength = 8000f;
        } else if (inputName.Equals("A") || inputName.Equals("D"))
        {
            pressedPosition = -20f;
            strength = 100000000000f;
        } else if (inputName.Equals("S"))
        {
            pressedPosition = 20f;
            strength = 100000000000f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = strength;
        spring.damper = 100f;

        if(Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        } else
        {
            spring.targetPosition = 0f;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
        
    }
}
