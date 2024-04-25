using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScriptAiGoal : MonoBehaviour
{
    public GameObject Bally;
    public GameObject AI;
    public int AiScore;
    public Text scoreText;
    public GameObject GameEndScreenLose;
    public bool PlayerLoses = true;
    public GameObject PlayerGoal;
    public GameObject AiGoal;
    public GameObject GotDeeem;



    [ContextMenu("IncreaseScoreAiScore")]
    public void addScore()

    {
        AiScore = AiScore + 1;
        scoreText.text = AiScore.ToString();

    }

    public void Update()
    {
        Bally.SetActive(true);
        GameEndScreenLose.SetActive(false);
        AiGoal.SetActive(true);
        PlayerGoal.SetActive(true);
        




        if (AiScore == 5)
        {
            Bally.SetActive(false);
            GameEndScreenLose.SetActive(true);
            gameOver();
            AiGoal.SetActive(false);
            PlayerGoal.SetActive(false);
            

        }
    }




    public void restartGame()
    {
        SceneManager.LoadScene("CountDown");


    }
    public void gameOver()
    {
        GameEndScreenLose.SetActive(true);
    }

}
