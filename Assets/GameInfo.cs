using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour 
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BasicClass PlayerClass { get; set; }
    public static int Str { get; set; }
    public static int Agi { get; set; }
    public static int Def { get; set; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
