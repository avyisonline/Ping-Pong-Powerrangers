using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour
{
    void loadOnePlayerGame()
    {
        SceneManager.LoadScene("Pong");
    }
    void loadTwoPlayerGame()
    {
        SceneManager.LoadScene("TwoPlayerPong");
    }
}
