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
    public GameObject lifeCoin1;
    public GameObject lifeCoin2;
    public GameObject lifeCoin3;
    public GameObject lifeCoin4;
    public GameObject lifeCoin5;

    public AudioSource walkingSound;
    public AudioSource hitSound;
    public AudioSource powerUpSound;
    public AudioSource shootSound;
    public AudioSource dyingSound;


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
        _playerActions.Player_Map_Kb1.Disable();
        _playerActions.Player_Map.Disable();
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
        else if (live == 0)
        {
            live3.SetActive(true);
            live2.SetActive(true);
            live1.SetActive(true);
            DyingAudio();
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
            if (_playerActions.Player_Map_Kb.Movement.inProgress)
            {
                if (!walkingSound.isPlaying)
                {
                    WalkingAudio();
                }
            }

            _moveInput = _playerActions.Player_Map_Kb.Movement.ReadValue<Vector2>();
            playerRB.velocity = _moveInput * movementSpeed;
        }
        else if (player2)
        {
            if (_playerActions.Player_Map.Movement.inProgress)
            {
                if (!walkingSound.isPlaying)
                {
                    WalkingAudio();
                }
            }
            
            _moveInput = _playerActions.Player_Map.Movement.ReadValue<Vector2>();
            _moveInput += _playerActions.Player_Map_Kb1.Movement.ReadValue<Vector2>();
            
            playerRB.velocity = _moveInput * movementSpeed;
        }
    }

    private void ShootProjektile()
    {
        if (player1)
        {
            if (_playerActions.Player_Map_Kb.Shoot.triggered)
            {
                //Debug.Log("F pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);
                ShootAudio();
            }
        }
        else if (player2)
        {
            if (_playerActions.Player_Map.Shoot.triggered || _playerActions.Player_Map_Kb1.Shoot.triggered)
            {
                //Debug.Log("Space pressed");
                Instantiate(projektilePrefab, firePoint.position, firePoint.rotation);
                ShootAudio();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Treffer");
            if (lives)
            {
                TakeDamage();
                HitAudio();
            }
        }

        if (other.gameObject.CompareTag("Border"))
        {
            Debug.Log("Gift");
            TakeDamage();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("LifeCoin"))
        {
            Debug.Log("Heal");
            addLife(other.gameObject);
        }
    }


    private void updateWinningCondition()
    {
        if (live < 1 || live > 3)
        {
            lives = false;
        }
    }

    public void addLife(GameObject collidingObject)
    {
        if (live >= 0 && live < 3)
        {
            live++;
        }

        collidingObject.SetActive(false);
    }

    public void HitAudio()
    {
        hitSound.Play();
    }

    public void ShootAudio()
    {
        shootSound.Play();
    }

    public void DyingAudio()
    {
        dyingSound.Play();
    }

    public void PowerUpAudio()
    {
        powerUpSound.Play();
    }

    public void WalkingAudio()
    {
        walkingSound.Play();
    }

    public bool GetDeath()
    {
        if (lives)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ResetPlayer()
    {
        ResetPosition();
        live = 3;
        lives = true;
        
        live3.SetActive(false);
        live2.SetActive(false);
        live1.SetActive(false);
        
    }
}