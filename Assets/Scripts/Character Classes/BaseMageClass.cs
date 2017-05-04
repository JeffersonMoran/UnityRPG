using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass
{
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A wise wizard, can cast spell";
        Stamina = 12;
        Strenght = 10;
        Endurance = 14;
        Dexterity = 8;
        Intellect = 18;
    }
}
