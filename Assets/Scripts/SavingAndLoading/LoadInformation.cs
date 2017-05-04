using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation
{ 
    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameInformation.Strenght = PlayerPrefs.GetInt("STRENGHT");
        GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");

        if (PlayerPrefs.GetString("EQUIPMENT1") != null)
            GameInformation.EquipmentOne = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM1"));
        /*

          TA ERRADO ACHO KEPPO;

         if (PlayerPrefs.GetString("EQUIPMENTITEM2") != null)
             GameInformation.EquipmentTwo = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM2"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM3") != null)
             GameInformation.EquipmentThree = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM3"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM4") != null)
             GameInformation.EquipmentFour = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM4"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM5") != null)
             GameInformation.EquipmentFive = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM5"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM6") != null)
             GameInformation.EquipmentSix = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM6"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM7") != null)
             GameInformation.EquipmentSeven = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM7"));
         if (PlayerPrefs.GetString("EQUIPMENTITEM8") != null)
             GameInformation.EquipmentEight = (BaseEquipment)(PPSerialization.Load("EQUIPMENTITEM8"));


             */

        //Teste Load pra weapon potion e scroll
        if (PlayerPrefs.GetString("WEAPON1") != null)
            GameInformation.WeaponOne = (BaseWeapon)(PPSerialization.Load("WEAPON1"));
        if (PlayerPrefs.GetString("POTION1") != null)
            GameInformation.PotionOne = (BasePotion)(PPSerialization.Load("POTION1"));
        if (PlayerPrefs.GetString("SCROLL1") != null)
            GameInformation.ScrollOne = (BaseScroll)(PPSerialization.Load("SCROLL1"));

    }
	
}
