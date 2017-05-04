using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass
{

    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A Strong and Powerfun hero";
        Stamina = 15;
        Endurance = 12;
        Strenght = 14;
        Intellect = 10;
        Dexterity = 10;
    }
	
}
