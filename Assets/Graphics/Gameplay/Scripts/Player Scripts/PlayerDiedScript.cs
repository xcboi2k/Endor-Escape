using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiedScript : MonoBehaviour
{
    public delegate void EndGame();
    public static event EndGame endGame;

    public GameObject continueMenu, scoreText1, scoreText2;
    
    void PlayerDied(){
        if (endGame != null){
            endGame();
        }

        Destroy(gameObject);
        Time.timeScale = 0f;
        continueMenu.SetActive(true);
        scoreText1.SetActive(false);
        scoreText2.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Collector"){
            PlayerDied();
        }
    }

    void OnCollisionEnter2D(Collision2D target) {
        if(target.gameObject.tag == "Ewok"){
            PlayerDied();
        }
    }


}
