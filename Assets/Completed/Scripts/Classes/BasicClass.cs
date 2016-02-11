using UnityEngine;
using System.Collections;

public class BasicClass
{
    private string className;
    private string classDescription;

    //Stats
    private int str;
    private int agi;
    private int def;

    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }

    public string ClassDescription
    {
        get { return classDescription; }
        set { classDescription = value; }
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
}
