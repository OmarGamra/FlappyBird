﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
   
{
    public float minY;
    public float maxY;
    public float distance;
    private float obstacleY;


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            obstacleY = Random.Range(minY,maxY);
            Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);
            col.gameObject.transform.position = spawnPosition;
        }


    
        
    }
}
