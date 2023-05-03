using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public bool gameStart;
    public void Start()
    { 
        countdownDisplay.gameObject.SetActive(true);
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "Go!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false); 
        gameStart = true;
    }
}
