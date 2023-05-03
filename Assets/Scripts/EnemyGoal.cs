using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnemyGoal : MonoBehaviour
{
    public GameObject puck;
    public GameObject player;
    public GameObject AI;
    public Text _playerScore;
    public int playerScore;
    public GameObject timer;
    public int maxScore = 5;
    public string scene = "Win";

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "AirHockeyPuck")
        {
            puck.transform.position = new Vector2(-0.23f, 0f);
            player.transform.position = new Vector2(-7f, 0f);
            AI.transform.position = new Vector2(7f, 0f);
            var puckrb = puck.GetComponent<Rigidbody2D>();
            puckrb.velocity = new Vector2(0, 0);
            playerScore++;
            _playerScore.text = playerScore.ToString();
            var _timer = timer.GetComponent<Timer>();
            _timer.countdownTime = 3;
            _timer.gameStart = false;
            _timer.Start();
        }

        if (playerScore == maxScore)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
