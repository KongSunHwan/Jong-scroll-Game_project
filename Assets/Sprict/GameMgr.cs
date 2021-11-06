using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject gameOverText;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (gameOver == true)
        {
            Debug.Log("GameOver!!!!!");
            gameOverText.SetActive(gameOver);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Game Exit!!!!!!!");
            Application.Quit();
        }
    }
}
