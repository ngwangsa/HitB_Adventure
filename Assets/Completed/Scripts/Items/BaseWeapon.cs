using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem      // BaseWeapon <- BaseStatItem <- BaseItem
{
    public enum WeaponTypes
    {
        DAGGER,
        KNIFE,
        SWORD,
        BOW,
        SHIELD
    }

    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffect
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
