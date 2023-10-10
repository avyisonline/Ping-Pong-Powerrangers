using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Scoring : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public int player1Score;
    public int player2Score;
    public TMP_Text scorePlayer1;
    public TMP_Text scorePlayer2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wallTriggerRight"))
        {
            xPosition = 0f;
            yPosition = 0f;
            player1Score++;
            Debug.Log("Player 1: " + player1Score + " points!");
        }

        if (collision.gameObject.CompareTag("wallTriggerLeft"))
        {
            xPosition = 0f;
            yPosition = 0f;
            player2Score++;
            Debug.Log("Player 2: " + player2Score + " points!");
        }
    }
}
