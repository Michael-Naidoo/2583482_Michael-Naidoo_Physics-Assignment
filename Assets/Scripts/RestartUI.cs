using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartUI : MonoBehaviour
{
    public string game = "SampleScene";

    public void RestartButton()
    {
        SceneManager.LoadScene(game);
    }
}
