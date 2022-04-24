using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    public GameState gameState = GameState.Running;

    public enum GameState 
    {
        Running,
        GameOver,
        Stopped,
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (gameState == GameState.Running)
        {
            if (player1.GetDeath())
            {
                Debug.Log("PLayer 1 looses");
                gameState = GameState.GameOver;
            }
            else if (player2.GetDeath())
            {
                Debug.Log("Player 2 looses");
                gameState = GameState.GameOver;
            }
        }
    }
}