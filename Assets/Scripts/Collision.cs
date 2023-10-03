using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;

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
        Debug.Log("OUCH");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("OUCH, MY HEAD! OR SOMETHING IN THE NEAR VICINITY!");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            Debug.Log("OUCH, MY ASS! OR MAYBE MY BALLS!");
            xSpeed = xSpeed * -1f;
        }
    }
}
