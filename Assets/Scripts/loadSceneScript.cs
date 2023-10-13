using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("Pong");
    }
    public void loadTwoPlayer()
    { 
        SceneManager.LoadScene("TwoPlayerPong");
    }

    public void loadPortals()
    {
        SceneManager.LoadScene("PongWithPortals");
    }
}
