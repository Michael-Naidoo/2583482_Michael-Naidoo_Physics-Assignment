using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class DirectionChanger : MonoBehaviour
    {
        public Vector2 newDir;
        public GameObject[] pos;
        public int countdownTime;
        public bool timerOn = true;
        public Rigidbody2D rb;
        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.name == "AirHockeyPuck")
            {
                float x = Random.Range(0f, 1f);
                float y = Random.Range(0f, 1f);
                newDir = new Vector2(x, y);
                var newVelocity = newDir.normalized * rb.velocity.magnitude;
                rb.velocity = newVelocity;
            }
        }

        public void Update()
        {
            var pos1trans = pos[0].GetComponent<Transform>();
            var pos1 = pos1trans.position;
            var pos2trans = pos[1].GetComponent<Transform>();
            var pos2 = pos2trans.position;
            var pos3trans = pos[2].GetComponent<Transform>();
            var pos3 = pos3trans.position;
            var trans = transform.position;
            var randX = Random.Range(pos1.x, pos2.x);
            var randY = Random.Range(pos3.y, pos1.y);
            var randPos = new Vector2(randX, randY);
            if (countdownTime == 0)
            {
                transform.position = randPos;
                countdownTime = 10;
            }
            if (timerOn)
            {
                StartCoroutine(CountdownToStart());
            }
        }
        IEnumerator CountdownToStart()
        {
            while (countdownTime > 0)
            {
                timerOn = false;
                yield return new WaitForSeconds(1f);
                countdownTime--;
                
            }

            yield return new WaitForSeconds(1f);
            countdownTime = 10;
            timerOn = true;
        }
    }
}