using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float movementSpeed;
    public object live1;
    public object live2;
    public object live3;
    private int live = 3;
    private bool lives = true;

    // Update is called once per frame
    void Update()
    {
        

    }

    public void TakeDamage()
    {
        
    }

    private void PlayerMovement()
    {
        playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * movementSpeed;
    }
}
