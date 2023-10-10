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

    public int player1Score;
    public int player2Score;
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
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
        }

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
