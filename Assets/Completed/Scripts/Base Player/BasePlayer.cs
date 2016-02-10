using UnityEngine;
using System.Collections;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;
    private BasicClass playerClass;
    private int str;
    private int agi;
    private int def;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BasicClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Str
    {
        get { return str; }
        set { str = value; }
    }

    public int Agi
    {
        get { return agi; }
        set { agi = value; }
    }

    public int Def
    {
        get { return def; }
        set { def = value; }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
