using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        LoadInfo.LoadAllInfo();
        Debug.Log("Player Name: " + GameInfo.PlayerName);
        //Debug.Log("Player Class: " + GameInfo.PlayerClass.ClassName);
        Debug.Log("Player Level: " + GameInfo.PlayerLevel);
        Debug.Log("Player Strength: " + GameInfo.Str);
        Debug.Log("Player Agility: " + GameInfo.Agi);
        Debug.Log("Player Defense: " + GameInfo.Def);
	}
	
}
