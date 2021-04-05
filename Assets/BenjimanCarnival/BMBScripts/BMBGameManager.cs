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

    private void Update()
    {
        scoreText.text = "Score: " + score;
    }

}
