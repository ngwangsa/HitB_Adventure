using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem
{

    private int str;
    private int agi;
    private int def;

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
