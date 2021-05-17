using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddPoints : MonoBehaviour
{
    public GameObject scoreboard;
    private TextMesh points;
    public int addPoints = 0;

    int num;

    // Start is called before the first frame update
    void Start()
    {
        this.points = scoreboard.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Int32.TryParse(this.points.text, out num);
        this.points.text = (num + this.addPoints).ToString();
    }
}
