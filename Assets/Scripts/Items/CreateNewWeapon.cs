﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon newWeapon;
   // private string[] weaponNames = new string[6]("Weapon of Greatness");
    
    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
          
        //assingn name to the weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create a weapon description
        newWeapon.ItemDescription = "This is a new Weapon.";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Endurance = Random.Range(1, 11);
        newWeapon.Intellect = Random.Range(1, 11);
        newWeapon.Strenght = Random.Range(1, 11);
        //choose the type of weapon
        ChooseWeaponType();
        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }
    
    public void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 7);
        if(randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }
        else if(randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        }
        else if (randomTemp == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
        }
    }

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Endurance.ToString());

    }
}
