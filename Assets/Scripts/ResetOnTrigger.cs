using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnTrigger : MonoBehaviour
{
    public PlayerController player1;

    public PlayerController player2;
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
        Debug.Log("Trigger");
        if (other.tag.Equals("Player1"))
        {
            player1.ResetPosition();
        }
        else if (other.tag.Equals("Player2"))
        {
            player2.ResetPosition();
        }
    }
}
