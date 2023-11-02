using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    public float speed = 7.5f; //<--- Important Strings
    public string leftOrRight; //<--- Important Strings
    public float maxValue = 3.8f; //<--- Important Strings

    //Paddle Control
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

    //Differenciate the two players :)
    void Update()
    {
        if (leftOrRight == "left") //<--- Told You Important Strings
        {
            paddleContorl(KeyCode.W, KeyCode.S); //Look at those button inputs

        }
        else if (leftOrRight == "right") //<--- Told You Important Strings
        {
            paddleContorl(KeyCode.UpArrow, KeyCode.DownArrow); //Aren't they just so edible I mean cool

        }

    }
}
