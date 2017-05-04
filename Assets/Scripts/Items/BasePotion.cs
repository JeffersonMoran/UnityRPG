using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasePotion : BaseStatItem
{
    public enum PotionTypes
    {
        HEALTH,
        MANA,
        STRENGHT,
        VITALITY,
        ENDURANCE,
        INTELLECT,
        SPEED
    }

    private PotionTypes potionType;
    private int spellEffectID;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
