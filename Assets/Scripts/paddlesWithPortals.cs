using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Just Paddles but for the Portal gamemode. Not much different from the normal one. 
/// Some stuff is also removed, like the second player! Because who needs friends anyway! ;w;
/// </summary>
public class paddlesWithPortals : MonoBehaviour
{
    public float speed = 7.5f;
    public string leftOrRight;
    public float maxValue = 1.2f;

    //Paddle Control
    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    //Differenciate the two players :)
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);

        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);

        }

    }
}
