using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject scoreboard;
    public float respawnX = 4f;
    public float respawnY = 1f;
    public float respawnZ = -5.74f;
    public GameObject endGameSoundObj;
    
    private TextMesh points;
    private Vector3 startingPosition;
    private AudioSource endGameAudioSource;




    // Start is called before the first frame update
    void Start()
    {
        this.points = scoreboard.GetComponent<TextMesh>();
        startingPosition = new Vector3(respawnX, respawnY, respawnZ);
        endGameAudioSource = endGameSoundObj.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {   
        this.points.text = "0";
        GameObject collider = collision.gameObject;
        collider.transform.position = new Vector3(startingPosition.x, startingPosition.y, startingPosition.z);
        endGameAudioSource.Play(0);
    }
}
