using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;

    private bool isMageClass;
    private bool isWarriorClass;
    private bool isRogueClass;
    private bool isRangerClass;
    private bool isClericClass;

    private string playerName = "EnterName";

    // Use this for initialization
    void Start()
    {
        newPlayer = new BasePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");
        isRangerClass = GUILayout.Toggle(isRangerClass, "Ranger Class");
        isClericClass = GUILayout.Toggle(isClericClass, "Cleric Class");
        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            else if (isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRogueClass();
            }
            else if (isRangerClass)
            {
                newPlayer.PlayerClass = new BaseRangerClass();
            }
            else if (isClericClass)
            {
                newPlayer.PlayerClass = new BaseClericClass();
            }

            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
            newPlayer.Name = playerName;

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Player Name: " + newPlayer.Name);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Stamina: " + newPlayer.Stamina);
            Debug.Log("Player Endurance: " + newPlayer.Endurance);
            Debug.Log("Player Strenght: " + newPlayer.Strenght);
            Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
            Debug.Log("Player Intellect: " + newPlayer.Intellect);
        }
        if(GUILayout.Button("Load"))
        {
            Application.LoadLevel("test");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.Name;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Stamina = newPlayer.Stamina;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Strenght = newPlayer.Strenght;
        GameInformation.Dexterity = newPlayer.Dexterity;
        GameInformation.Intellect = newPlayer.Intellect;
    }
}
