using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float forceApplied = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        float force = forceApplied;
        
        Vector3 dir = collision.transform.position - this.transform.position;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(-dir.normalized * force);
    }
}
