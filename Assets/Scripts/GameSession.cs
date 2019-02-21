using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

    private int score = 0;

    private void Awake()
    {
        SetUpSingleton(); 
    }

    private void SetUpSingleton()
    {
        int numberOfGamesSessions = FindObjectsOfType<GameSession>().Length;
        if (numberOfGamesSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
