using UnityEngine;
using System.Collections;

public class LoadInfo
{
    public static void LoadAllInfo()
    {
        GameInfo.PlayerName = PlayerPrefs.GetString("PLAYER_NAME");
        GameInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYER_LEVEL");
        GameInfo.Str = PlayerPrefs.GetInt("PLAYER_STR");
        GameInfo.Agi = PlayerPrefs.GetInt("PLAYER_AGI");
        GameInfo.Def = PlayerPrefs.GetInt("PLAYER_DEF");
        Debug.Log("Game Loaded");
    }
	

}
