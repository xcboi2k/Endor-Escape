using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseContinueControllerScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public Text scoreText;
    int score = 0;

    void Update() {
        score++;
        scoreText.text = "" + score;
    }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameplayScene");
    }

    public void Menu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}
