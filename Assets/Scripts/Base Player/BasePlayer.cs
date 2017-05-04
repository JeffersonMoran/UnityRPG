using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{
    private string name;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int stamina;
    private int endurance;
    private int dexterity;
    private int intellect;
    private int strenght;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public int Strenght
    {
        get { return strenght; }
        set { strenght = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

}
