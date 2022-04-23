using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAction : MonoBehaviour
{
    [SerializeField] 
    private float _speed;

    private PlayerActions _playerActions;
    private Rigidbody2D _rbody;
    private Vector2 _moveInput;

    private void Awake()
    {
        _playerActions = new PlayerActions();
        _rbody = GetComponent<Rigidbody2D>();
        if (_rbody is null)
        {
            Debug.LogError("Rigigbody2D is null!");
        }
    }

    private void OnEnable()
    {
        _playerActions.Player_Map.Enable();
    }

    private void OnDisable()
    {
        _playerActions.Player_Map.Disable();
    }

    private void FixedUpdate()
    {
        _moveInput = _playerActions.Player_Map.Movement.ReadValue<Vector2>();
        _rbody.velocity = _moveInput * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
