using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CountdownS : MonoBehaviour
{
    public float timeLeft = 5.0f;
    public Text startText;

        private void Update()
    { 
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Game");
        }
    }


}  



// Count Down uses a float of 5 seconds, it is in its own secene and is timed to allow game to start after time is up.
// i did originally do everything in engine but it required me to use a destroy function
//i could not get it working and it would start counting in minus