using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMainMenu : MonoBehaviour
{
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("CountDown");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }


}

// Script not in use fo now