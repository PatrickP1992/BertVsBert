using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float movementSpeed;
    public GameObject projektilePrefab;
    public Transform firePoint;
    public bool player1;
    public bool player2;
    public object live1;
    public object live2;
    public object live3;
    private int live = 3;
    private bool lives = true;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        ShootProjektile();
    }

    public void TakeDamage()
    {

    }

    private void PlayerMovement()
    {
        if (player1)
        {
            playerRB.velocity = new Vector2(Input.GetAxisRaw("HorizontalPlayer1"), Input.GetAxisRaw("VerticalPlayer1")) * movementSpeed;
        }
        else if (player2)
        {
            playerRB.velocity = new Vector2(Input.GetAxisRaw("HorizontalPlayer2"), Input.GetAxisRaw("VerticalPlayer2")) * movementSpeed;
        }


    }

    private void ShootProjektile()
    {
        if (player1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);
            }
        }
        else if (player2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);
            }
        }

    }
}