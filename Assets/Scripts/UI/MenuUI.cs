using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public InputHandler inputHandler;

    void Start() 
    {
        GMCode.GameManager.GetInstance().OnGameOverAction += gameOver;
    }

    public void startGame() 
    {
        mainMenu.SetActive(false);
    }

    public void pauseGame() 
    {
        pauseMenu.SetActive(true);
        GMCode.GameManager.GetInstance().pauseGame();
    }

    public void resumeGame() 
    {
        pauseMenu.SetActive(false);
        GMCode.GameManager.GetInstance().resumeGame();
    }

    public void quitGame() 
    {
        Application.Quit();
    }

    public void gameOver() 
    {
        gameOverMenu.SetActive(true);
    }

    private void OnEnable() 
    {
        inputHandler.OnPauseAction += pauseGame;
    }

    private void OnDisable() 
    {
        inputHandler.OnPauseAction -= pauseGame;
    }

    public void retry () 
    {
        gameOverMenu.SetActive(false);
        mainMenu.SetActive(true);
        GMCode.GameManager.GetInstance().retry();
    }
}
