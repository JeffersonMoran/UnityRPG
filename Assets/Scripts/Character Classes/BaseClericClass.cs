using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClericClass : BaseCharacterClass
{
    public BaseClericClass()
    {
        CharacterClassName = "Cleric";
        CharacterClassDescription = "A devoted man that supports the team";
        Stamina = 8;
        Endurance = 9;
        Strenght = 7;
        Intellect = 18;
        Dexterity = 10;
    }

}
