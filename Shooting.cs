using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    private Transform playerPos;

    public AudioClip shootingSound;
    public AudioSource audioSource;


    void Start()
    {
        playerPos = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, playerPos.position, Quaternion.identity);
            audioSource.PlayOneShot(audioSource.clip, 1F);
        }
    }
}
