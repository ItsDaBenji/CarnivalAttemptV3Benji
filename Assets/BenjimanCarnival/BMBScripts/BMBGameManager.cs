using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BMBGameManager : MonoBehaviour
{

    public static BMBGameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public int score;

    public Text scoreText;

    public float timeLeft;

    public Text timeText;

    private void Update()
    {
        scoreText.text = "Score: " + score;
        if (timeLeft < 0)
        {
            timeLeft -= Time.deltaTime;
            timeText.text = "Time: " + (int)timeLeft;
        }
        else
        {
            timeText.text = "Time: 0";
            Time.timeScale = 0;
        }
    }

}
