using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseEquipment EquipmentOne { get; set; }

    /* 
      
       public static BaseEquipment EquipmentTwo { get; set; }
       public static BaseEquipment EquipmentThree { get; set; }
       public static BaseEquipment EquipmentFour { get; set; }
       public static BaseEquipment EquipmentFive { get; set; }
       public static BaseEquipment EquipmentSix { get; set; }
       public static BaseEquipment EquipmentSeven { get; set; }
       public static BaseEquipment EquipmentEight { get; set; }
        TA ERRADO ACHO
         
         */

    public static BasePotion PotionOne { get; set; }
    public static BaseScroll ScrollOne { get; set; }
    public static BaseWeapon WeaponOne { get; set; }
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Stamina { get; set; }
    public static int Endurance { get; set; }
    public static int Intellect { get; set; }
    public static int Strenght { get; set; }
    public static int Dexterity { get; set; }
}
