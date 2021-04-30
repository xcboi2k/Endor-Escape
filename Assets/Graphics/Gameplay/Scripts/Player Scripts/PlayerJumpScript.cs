using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJumpScript : MonoBehaviour
{
    //public Audioclip jumpClip;
    private float jumpForce = 12f, forwardForce = 0f;
    
    private Rigidbody2D rb;

    private bool canJump;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(rb.velocity.y) == 0){
            canJump = true;
        }
    }

    public void Jump(){
        if(canJump){
            canJump = false;
            //AudioSource.PlayClipAtPoint(jumpClip, transform.position);

            if(transform.position.x < 0){
            forwardForce = 1f;
            }

            else{
                forwardForce = 0f;
            }
        }

        rb.velocity = new Vector2(forwardForce, jumpForce);
    }
}
