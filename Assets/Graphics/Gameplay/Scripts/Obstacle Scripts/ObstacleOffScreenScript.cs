﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleOffScreenScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Collector"){
            gameObject.SetActive(false);
        }
    }
}
