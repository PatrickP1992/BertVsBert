using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DarknessItem : MonoBehaviour
{
    public GameObject blackScreenLeft;
    public GameObject blackScreenRight;
    public BoxCollider2D col;
    public SpriteRenderer spriteRen;
    public Rigidbody2D rBody;
    public PlayerController player1;
    public PlayerController player2;
    public AudioSource powerUpSound;
    public Transform respawnPoint;
    public Transform boundUp;
    public Transform boundBottom;
    public Transform boundRight;
    public Transform boundLeft;

    public float speedLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }

    public void PowerUpAudio()
    {
        powerUpSound.Play();
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player1"))
        {
            blackScreenLeft.SetActive(true);
            PowerUpAudio();
            StartCoroutine(waitTime(3));
            spriteRen.enabled = false;
            col.enabled = false;
            StartCoroutine(waitTime2(5));
            player1.ResetPosition();
        }
        else if (other.tag.Equals("Player2"))
        {
            blackScreenRight.SetActive(true);
            PowerUpAudio();
            StartCoroutine(waitTime(3));
            spriteRen.enabled = false;
            col.enabled = false;
            StartCoroutine(waitTime2(5));
            player2.ResetPosition();
        }
    }

    IEnumerator waitTime(int sec)
    {
        yield return new WaitForSeconds(sec);
        blackScreenRight.SetActive(false);
        blackScreenLeft.SetActive(false);
        
    }
    IEnumerator waitTime2(int sec)
    {
        yield return new WaitForSeconds(sec);
        
        spriteRen.enabled = true;
        col.enabled = true;
    }

    public void ResetPostion()
    {
        gameObject.transform.position = respawnPoint.transform.position;
        rBody.velocity = new Vector2();
    }
    
    private void CheckBounds()
    {
        if (gameObject.transform.position.x > boundRight.transform.position.x)
        {
            ResetPostion();
        }
        
        if (gameObject.transform.position.x < boundLeft.transform.position.x)
        {
            ResetPostion();
        }
        
        if (gameObject.transform.position.y > boundUp.transform.position.y)
        {
            ResetPostion();
        }
        
        if (gameObject.transform.position.y < boundBottom.transform.position.y)
        {
            ResetPostion();
        }
    }
    
}
