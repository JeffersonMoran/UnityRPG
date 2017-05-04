using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;
	// Use this for initialization
	void Start ()
    {
        currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(currentState);
	    switch(currentState)
        {
            case (BattleStates.START)://setup battle functions
                break;
            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;
        }	
	}

    void OnGUI()
    {
        if (GUILayout.Button("Next State"))
        {
            currentState = (BattleStates)(((int)currentState + 1) % 5);
        }
    }
}
