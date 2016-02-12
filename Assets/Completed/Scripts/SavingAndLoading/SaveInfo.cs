using UnityEngine;
using System.Collections;

public class SaveInfo
{
    public static void SaveAllInfo()
    {
        PlayerPrefs.SetString("PLAYER_NAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("PLAYER_LEVEL", GameInfo.PlayerLevel);
        PlayerPrefs.SetInt("PLAYER_STR", GameInfo.Str);
        PlayerPrefs.SetInt("PLAYER_AGI", GameInfo.Agi);
        PlayerPrefs.SetInt("PLAYER_DEF", GameInfo.Def);
        Debug.Log("Game Saved");
    }
}
