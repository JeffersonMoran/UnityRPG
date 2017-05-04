using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    private BaseCharacterClass class1 = new BaseMageClass();
    private BaseCharacterClass class2 = new BaseWarriorClass();
    private BaseCharacterClass class3 = new BaseRangerClass();
    private BaseCharacterClass class4 = new BaseRogueClass();
    private BaseCharacterClass class5 = new BaseClericClass();

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnGUI()
    {
        //warrior
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Intellect.ToString());

        //wizard
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Strenght.ToString());

        //rogue
        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescription);
        GUILayout.Label(class3.Dexterity.ToString());

        //ranger
        GUILayout.Label(class4.CharacterClassName);
        GUILayout.Label(class4.CharacterClassDescription);
        GUILayout.Label(class4.Dexterity.ToString());

        //cleric
        GUILayout.Label(class5.CharacterClassName);
        GUILayout.Label(class5.CharacterClassDescription);
        GUILayout.Label(class5.Intellect.ToString());
    }
}
