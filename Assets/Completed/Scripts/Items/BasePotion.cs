using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem
{

    public enum PotionTypes
    {
        HEALTH,
        MANA
    }

    private PotionTypes potionType;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
}
