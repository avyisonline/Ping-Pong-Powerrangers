using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public string leftOrRight;
    public float maxValue = 3.8f;
    void paddleContorl(KeyCode up, KeyCode down)
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

    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleContorl(KeyCode.W, KeyCode.S);

        }
        else if (leftOrRight == "right")
        {
            paddleContorl(KeyCode.UpArrow, KeyCode.DownArrow);

        }
    }
}
