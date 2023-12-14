using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;
    public static float gameScoreCol=0f;
    public Transform trans;


    public void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
            gameScoreCol = trans.position.z;
        }
    }

}
