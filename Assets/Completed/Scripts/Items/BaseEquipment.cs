using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem
{

	public enum EquipmentTypes
    {
        HEADGEAR,
        BODY,
        FEET,
        ACCESSORY
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int SpellEffect
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
