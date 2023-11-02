using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Basically just the paddlescript;
/// but a robot.
/// OOOOOOOooooOOOoooOOoooOOOOOoooO
/// (It follows the ball. It is currently *perfect* ***ALL OF THE TIME***)
/// </summary>

public class BotPaddle : MonoBehaviour
{
    public float yPosition = 0f;
    public float ySpeed = 5f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    yPosition = yPosition + ySpeed * Time.deltaTime;

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bot"))
        {
            ySpeed = ySpeed * -1f;
        }
    }

    //The thing that makes it be unbeatable, and always follow the ball 
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f); //the shit that makes to stick to the ball.
    }
}
