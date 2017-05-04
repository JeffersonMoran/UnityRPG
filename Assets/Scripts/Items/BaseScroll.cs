using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseScroll : BaseItem
{
    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

}
