using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBouncerSound : MonoBehaviour
{
    public GameObject speaker;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = speaker.GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play(0);
    }
}
