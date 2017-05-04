using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass
{

    public BaseRogueClass()
    {
        CharacterClassName = "Rogue";
        CharacterClassDescription = "They have a knack for finding the solution to just about any problem";
        Stamina = 10;
        Endurance = 13;
        Strenght = 10;
        Intellect = 11;
        Dexterity = 15;
    }

}