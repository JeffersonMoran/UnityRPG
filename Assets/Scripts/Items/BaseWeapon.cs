using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon : BaseStatItem //base weapon <- baseStatItem <- baseItem
{
    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM
    }
    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType
    {
        get{return weaponType;}
        set{weaponType = value;}
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
