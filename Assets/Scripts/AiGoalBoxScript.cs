using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiGoalBoxScript : MonoBehaviour

{
    public LogicScriptAiGoal logic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}

// all i know is that it basically keepts the triggers and allows thwem to be affected by the scoring syste
