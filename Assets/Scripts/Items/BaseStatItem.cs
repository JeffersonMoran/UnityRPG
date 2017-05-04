using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseStatItem : BaseItem
{
    private int stamina;
    private int endurance;
    private int strenght;
    private int dexterity;
    private int intellect;

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
