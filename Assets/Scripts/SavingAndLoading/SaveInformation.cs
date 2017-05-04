using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("STAMINA", GameInformation.Stamina);
        PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("STRENGHT", GameInformation.Strenght);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);

        if(GameInformation.EquipmentOne != null)
            PPSerialization.Save("EQUIPMENTITEM1", GameInformation.EquipmentOne);

        /*     if((GameInformation.EquipmentTwo != null))
                 PPSerialization.Save("EQUIPMENTITEM2", GameInformation.EquipmentTwo);
             if ((GameInformation.EquipmentThree != null))
                 PPSerialization.Save("EQUIPMENTITEM3", GameInformation.EquipmentThree);
             if ((GameInformation.EquipmentFour != null))
                 PPSerialization.Save("EQUIPMENTITEM4", GameInformation.EquipmentFour);
             if ((GameInformation.EquipmentFive != null))
                 PPSerialization.Save("EQUIPMENTITEM5", GameInformation.EquipmentFive);
             if ((GameInformation.EquipmentSix != null))
                 PPSerialization.Save("EQUIPMENTITEM6", GameInformation.EquipmentSix);
             if ((GameInformation.EquipmentSeven != null))
                 PPSerialization.Save("EQUIPMENTITEM7", GameInformation.EquipmentSeven);
             if ((GameInformation.EquipmentEight != null))
                 PPSerialization.Save("EQUIPMENTITEM8", GameInformation.EquipmentEight); NAO SEI SE TA CERTO KEPPO*/

        //teste pra salvar potion weapon e scroll
        if (GameInformation.PotionOne != null)
            PPSerialization.Save("POTION1", GameInformation.PotionOne);
        if (GameInformation.WeaponOne != null)
            PPSerialization.Save("WEAPON1", GameInformation.WeaponOne);
        if (GameInformation.ScrollOne != null)
            PPSerialization.Save("SCROLL1", GameInformation.ScrollOne);
        Debug.Log("Saved all information");
    }

}
