
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class script_ColumnsTrigger : MonoBehaviour
{
    public script_GameLogicManager gameLogicManager;
    private bool isActivated = false;
    public int scorePerColumns = 2;

    // Start is called before the first frame update
    void Start()
    {
        gameLogicManager = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<script_GameLogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActivated == false && collision.gameObject.layer == 3)
        {
            gameLogicManager.AddScore(scorePerColumns);
            isActivated = true;
        }
    }
}
