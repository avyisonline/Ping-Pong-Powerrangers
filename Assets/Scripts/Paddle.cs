using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// This little thingy here makes it so that in all modes, YOU are in control of your paddle. And in Two Player it does the same for the the second player As well.
/// It makes the thing to the correct speed, it makes it not go out of bounds, it makes it so W and S are the controls for P1 and ArrowUp and ArrowDown are the stuff for P2.
/// And it makes me very happy with all of it :]
/// </summary>

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
