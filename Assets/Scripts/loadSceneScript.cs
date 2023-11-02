using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("Pong"); //Singeplayer
    }
    public void loadTwoPlayer()
    { 
        SceneManager.LoadScene("TwoPlayerPong"); //Multiplayer
    }

    public void loadPortals()
    {
        SceneManager.LoadScene("PongWithPortals"); //Portals (Singleplayer)
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu"); //Main Menu
    }
}
