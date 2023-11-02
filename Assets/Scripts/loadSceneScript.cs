using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Literally the entire reason the Home menu, and Home buttons work.
/// It identifies the scenes and loads them. Pretty useful!
/// </summary>

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
