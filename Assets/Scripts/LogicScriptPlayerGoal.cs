using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScriptPlayerGoal : MonoBehaviour
{
    public GameObject Bally;
    public GameObject Player;
    public int playerScore;
    public Text scoreText;
    public GameObject GameEndScreenWin;
    public bool PlayerWins = true;
    public Scene CountDown;
    public GameObject PlayerGoal;
    public GameObject AiGoal;
    public GameObject GotDeeem;

   

    [ContextMenu("IncreaseScorePlayerScore")]
    public void addScore()

    {
        
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();


    }

    public void Update()
    {
        GameEndScreenWin.SetActive(false);
        Player.SetActive(true);
        AiGoal.SetActive(true);
        PlayerGoal.SetActive(true);
        GotDeeem.SetActive(false);

        if (playerScore == 5)
        {
          
            GameEndScreenWin.SetActive(true);
            gameOver();
            Player.SetActive(false);
            AiGoal.SetActive(false);
            PlayerGoal.SetActive(false);
            GotDeeem.SetActive(true);
            

        }
    }


    public void restartGame()
    {
        SceneManager.LoadScene("CountDown");


    }
    public void gameOver()
    {
        GameEndScreenWin.SetActive(true);

        
     }

    


    

}

//ScoringText system which adds and manages text to add scores of player 