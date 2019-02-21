using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    
    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartMenu(){
        SceneManager.LoadScene(0);
    }

    public void LoadMainGame(){
        SceneManager.LoadScene("Game One");
        if (FindObjectOfType<GameSession>())
        {
            FindObjectOfType<GameSession>().ResetGame();
        }
    }

    public void LoadGameOver(){
        StartCoroutine(WaitAndLoad());
    }

    public void QuitGame(){
        Application.Quit();
    }

    IEnumerator WaitAndLoad(){
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }
}
