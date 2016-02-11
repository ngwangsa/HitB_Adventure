using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour
{
    private BasicClass class1 = new BaseWarrior();
    private BasicClass class2 = new BaseArcher();

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        GUILayout.Label(class1.ClassName);
        GUILayout.Label(class1.ClassDescription);
        GUILayout.Label(class1.Str.ToString());

        GUILayout.Label(class2.ClassName);
        GUILayout.Label(class2.ClassDescription);
        GUILayout.Label(class2.Agi.ToString());
    }
}
