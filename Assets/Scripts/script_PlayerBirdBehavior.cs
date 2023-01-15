
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script_PlayerBirdBehavior : MonoBehaviour
{
    public Rigidbody2D rigidBodyBird;
    public float jumpPower;
    public script_GameLogicManager gameLogicManager;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameLogicManager = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<script_GameLogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            rigidBodyBird.velocity = Vector2.up * jumpPower;
        }

        if (transform.position.y > 14 || transform.position.y < -14)
        {
            KillBird();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        KillBird();
    }

    private void KillBird()
    {
        gameLogicManager.gameOver();
        birdIsAlive = false;
    }
}
