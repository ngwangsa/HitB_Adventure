using UnityEngine;
using System.Collections;

public class TurnBasedStateMachine : MonoBehaviour
{

    public enum States
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private States currentState;

	// Use this for initialization
	void Start () 
    {
        currentState = States.START;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log(currentState);
	    switch(currentState)
        {
            case (States.START):
                // Setup battle function
                break;
            case (States.PLAYERCHOICE):
                break;
            case (States.ENEMYCHOICE):
                break;
            case (States.LOSE):
                break;
            case (States.WIN):
                break;
        }
	}

    void OnGUI()
    {
        if(GUILayout.Button("NEXT STATE"))
        {
            if(currentState == States.START)
            {
                currentState = States.PLAYERCHOICE;
            }
            else if (currentState == States.PLAYERCHOICE)
            {
                currentState = States.ENEMYCHOICE;
            }
            else if (currentState == States.ENEMYCHOICE)
            {
                currentState = States.LOSE;
            }
            else if (currentState == States.LOSE)
            {
                currentState = States.WIN;
            }
            else if (currentState == States.WIN)
            {
                currentState = States.START;
            }
        }
    }
}
