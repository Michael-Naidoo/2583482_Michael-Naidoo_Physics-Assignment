using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerGoal : MonoBehaviour
{
    public GameObject puck;
    public GameObject player;
    public GameObject AI;
    public Text _AIScore;
    public int AIScore;
    public GameObject timer;
    public int maxScore = 5;
    public string scene = "Loose";

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "AirHockeyPuck")
        {
            puck.transform.position = new Vector2(-0.23f, 0f);
            player.transform.position = new Vector2(-7f, 0f);
            AI.transform.position = new Vector2(7f, 0f);
            var puckrb = puck.GetComponent<Rigidbody2D>();
            puckrb.velocity = new Vector2(0, 0);
            AIScore++;
            _AIScore.text = AIScore.ToString();
            var _timer = timer.GetComponent<Timer>();
            _timer.countdownTime = 3;  
            _timer.gameStart = false;
            _timer.Start();
        }

        if (AIScore == maxScore)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
