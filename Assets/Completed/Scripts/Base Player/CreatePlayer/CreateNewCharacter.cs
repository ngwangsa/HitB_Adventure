using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour 
{
    private BasePlayer newPlayer;
    private bool isWarriorClass;
    private bool isArcherClass;
    private string playerName = "Enter Name";

	// Use this for initialization
	void Start () 
    {
	    newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        isArcherClass = GUILayout.Toggle(isArcherClass, "Archer Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        if(GUILayout.Button("Create"))
        {
            if(isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarrior();
            }
            else if(isArcherClass)
            {
                newPlayer.PlayerClass = new BaseArcher();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Str = newPlayer.PlayerClass.Str;
            newPlayer.Agi = newPlayer.PlayerClass.Agi;
            newPlayer.Def = newPlayer.PlayerClass.Def;
            newPlayer.PlayerName = playerName;

            storeNewPlayerInfo();
            SaveInfo.SaveAllInfo();

            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.ClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Strength: " + newPlayer.Str);
            Debug.Log("Player Agility: " + newPlayer.Agi);
            Debug.Log("Player Defense: " + newPlayer.Def);

        }
        if(GUILayout.Button("Load"))
        {
            Application.LoadLevel("test");
        }
    }

    private void storeNewPlayerInfo()
    {
        GameInfo.PlayerName = newPlayer.PlayerName;
        GameInfo.PlayerLevel = newPlayer.PlayerLevel;
        GameInfo.Str = newPlayer.Str;
        GameInfo.Agi = newPlayer.Agi;
        GameInfo.Def = newPlayer.Def;
    }
}
