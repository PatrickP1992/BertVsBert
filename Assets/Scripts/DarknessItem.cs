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

    public float speedLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player1"))
        {
            blackScreenLeft.SetActive(true);
            StartCoroutine(waitTime(3));
            spriteRen.enabled = false;
            col.enabled = false;
            StartCoroutine(waitTime2(5));
        }
        else if (other.tag.Equals("Player2"))
        {
            blackScreenRight.SetActive(true);
            StartCoroutine(waitTime(3));
            spriteRen.enabled = false;
            col.enabled = false;
            StartCoroutine(waitTime2(5));
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

    
}
