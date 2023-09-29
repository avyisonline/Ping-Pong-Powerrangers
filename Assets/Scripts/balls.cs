using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
            transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
}
