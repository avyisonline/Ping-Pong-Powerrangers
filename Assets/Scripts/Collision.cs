using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;

    public int player1Score = 0;
    public int player2Score = 0;
    public TMP_Text scorePlayer1;
    public TMP_Text scorePlayer2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime; //Time = Fate
        yPosition = yPosition + ySpeed * Time.deltaTime; //Time = $$$
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1.01f; //Bounce Off of Wall
        }
        else if (collision.gameObject.CompareTag("specialWall"))
        {
            xSpeed = xSpeed * -1.01f; //Bounce Off of Wall
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f; //Bounce Off of Player + Add more *speed*
        }

        if (collision.gameObject.CompareTag("wallTriggerRight")) //Right Wall Shenanigans
        {
            xPosition = Random.Range(1f, -1f); //Random Placement, 'cause otherwise it's just boring??
            yPosition = Random.Range(-4f, 4f); //Random Placement, 'cause otherwise it's just boring??
            ySpeed = -4f;
            xSpeed = -4f;
            player1Score++;
            scorePlayer1.text = player1Score.ToString();
            Debug.Log("Player 1: " + player1Score + " points!");
        }

        if (collision.gameObject.CompareTag("wallTriggerLeft")) //Left Wall Shenanigans
        {
            xPosition = Random.Range(1f, -1f); //Random Placement, 'cause otherwise it's just boring??
            yPosition = Random.Range(-4f, 4f); //Random Placement, 'cause otherwise it's just boring??
            ySpeed = 4f;
            xSpeed = 4f;
            player2Score++;
            scorePlayer2.text = player2Score.ToString();
            Debug.Log("Player 2: " + player2Score + " points!");
        }

        if(player1Score >= 10) //Victory! Player One
        {
            scorePlayer1.text = "Player 1 Wins!";
            yPosition = 128f; //Ball Be Gone
            xPosition = 128f; //Ball Be Gone
            ySpeed = 0; //Ball Be Stopped
            xSpeed = 0; //Ball Be Stopped
        }

        else if (player2Score >= 10) //Victory! Player Two
        {
            scorePlayer2.text = "Player 2 Wins";
            yPosition = 128f; //Ball Be Gone
            xPosition = 128f; //Ball Be Gone
            ySpeed = 0; //Ball Be Stopped
            xSpeed = 0; //Ball Be Stopped
        }
    }
}
