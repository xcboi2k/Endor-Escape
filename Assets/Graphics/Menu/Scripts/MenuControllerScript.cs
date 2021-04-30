using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("GameplayScene");
    }

    public void Exit(){
        Application.Quit();
    }
}
