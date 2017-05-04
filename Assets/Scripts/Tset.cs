using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tset : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Stamina: " + GameInformation.Stamina);
        Debug.Log("Player Strenght: " + GameInformation.Strenght);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
        Debug.Log("Player Intellect: " + GameInformation.Intellect);
        Debug.Log("Player Endurance: " + GameInformation.Endurance);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
