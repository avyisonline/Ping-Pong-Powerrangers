using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collisionWithPortals : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;

    public int playerScore = 0;
    public TMP_Text scorePlayer;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5f, yPosition, 0f);
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
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
            playerScore++;
            scorePlayer.text = playerScore.ToString();
        }

        if (collision.gameObject.CompareTag("wallTriggerRight"))
        {
            xPosition = -8.5f;
            yPosition = 0f;
            ySpeed = 4f;
            xSpeed = 4f;
        }

        if (collision.gameObject.CompareTag("wallTriggerLeft"))
        {
            xPosition = 8.5f;
            yPosition = 0f;
            ySpeed = -4f;
            xSpeed = -4f;
        }

    }
}
