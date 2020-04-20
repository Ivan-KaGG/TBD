using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void HappyScene()
    {
        SceneManager.LoadScene(2);
    }

    public void SadScene()
    {
        SceneManager.LoadScene(3);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
