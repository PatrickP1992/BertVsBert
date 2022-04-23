using System;
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
    public Transform startPosition;
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;

    private int live = 3;
    private bool lives = true;
    private PlayerActions _playerActions;
    private Vector2 _moveInput;


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        ShootProjektile();
        updateWinningCondition();
    }

    private void Awake()
    {
        _playerActions = new PlayerActions();
    }

    private void OnEnable()
    {
        _playerActions.Player_Map_Kb.Enable();
        _playerActions.Player_Map_Kb1.Enable();
        _playerActions.Player_Map.Enable();
    }

    private void OnDisable()
    {
        _playerActions.Player_Map_Kb.Disable();
    }

    public void TakeDamage()
    {
        live--;
        if (live == 2)
        {
            live3.SetActive(true);

        }
        else if (live == 1)
        {
            live3.SetActive(true);
            live2.SetActive(true);
        }
        else if (live <= 0)
        {
            live3.SetActive(true);
            live2.SetActive(true);
            live1.SetActive(true);
        }
    }

    public void ResetPosition()
    {
        gameObject.transform.position = startPosition.transform.position;
    }

    private void PlayerMovement()
    {
        if (player1)
        {
            //playerRB.velocity = new Vector2(Input.GetAxisRaw("HorizontalP1"), Input.GetAxisRaw("VerticalP1")) * movementSpeed;
            _moveInput = _playerActions.Player_Map_Kb.Movement.ReadValue<Vector2>();
            playerRB.velocity = _moveInput * movementSpeed;
        }
        else if (player2)
        {
            //playerRB.velocity = new Vector2(Input.GetAxisRaw("HorizontalP2"), Input.GetAxisRaw("VerticalP2")) * movementSpeed;
            _moveInput = _playerActions.Player_Map.Movement.ReadValue<Vector2>();
            playerRB.velocity = _moveInput * movementSpeed;
        }


    }

    private void ShootProjektile()
    {
        if (player1)
        {
            if (_playerActions.Player_Map_Kb.Shoot.triggered)
            {
                Debug.Log("F pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);
            }
        }
        else if (player2)
        {
            if (_playerActions.Player_Map.Shoot.triggered)
            {
                Debug.Log("Space pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Treffer");
            TakeDamage();
        }
        if (other.gameObject.CompareTag("Border"))
        {
            Debug.Log("Gift");
            TakeDamage();
        }
    }


    private void updateWinningCondition()
    {
        if (live <= 1 && live >= 3)
        {
            lives = false;
        }
    }

}