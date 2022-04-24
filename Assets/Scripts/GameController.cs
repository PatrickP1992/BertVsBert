using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    public GameState gameState = GameState.Running;
    public Text scorePlayer1;
    public Text scorePlayer2;
    public Text winningText;
    public Text pressR;
    public int pointLimit;
    public Button resetButton;
    private int _scoreP1 = 0;
    private int _scoreP2 = 0;

    public enum GameState 
    {
        Running,
        GameOver,
        Stopped,
    }
    // Start is called before the first frame update
    void Start()
    {
        resetButton.onClick.AddListener(RestartGame);
    }

    private void Awake()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckGameOver();

        if (gameState == GameState.Running || gameState == GameState.GameOver)
        {
            pressR.enabled = false;
        }
        else
        {
            pressR.enabled = true;
        }
    }

    private void CheckGameOver()
    {
        if (gameState == GameState.Running)
        {
            if (player1.GetDeath())
            {
                Debug.Log("PLayer 1 looses");
                gameState = GameState.GameOver;
                _scoreP2++;
                scorePlayer2.text = _scoreP2.ToString();
                if (_scoreP2 == pointLimit)
                {
                    gameState = GameState.Stopped;
                    Debug.Log("PLayer 2 won");
                    winningText.text = "Player 2 won!!";
                    winningText.enabled = true;
                }
            }
            else if (player2.GetDeath())
            {
                Debug.Log("Player 2 looses");
                gameState = GameState.GameOver;
                _scoreP1++;
                scorePlayer1.text = _scoreP1.ToString();
                if (_scoreP1 == pointLimit)
                {
                    gameState = GameState.Stopped;
                    Debug.Log("PLayer 1 won");
                    winningText.text = "Player 1 won!!";
                    winningText.enabled = true;
                }
            }
        }

        if (gameState == GameState.GameOver)
        {
            ResetGame();
        }
    }

    private void ResetGame()
    {
        player1.ResetPlayer();
        player2.ResetPlayer();
        gameState = GameState.Running;
    }

    public void RestartGame()
    {
        if (gameState == GameState.Stopped)
        {
            Debug.Log ("You have clicked the button!");
            winningText.enabled = false;
            player1.ResetPlayer();
            player2.ResetPlayer();
            _scoreP1 = 0;
            _scoreP2 = 0;
            scorePlayer1.text = _scoreP1.ToString();
            scorePlayer2.text = _scoreP2.ToString();
            gameState = GameState.Running;
        }
    }
}