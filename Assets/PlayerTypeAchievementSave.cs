﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerTypeAchievementSave : MonoBehaviour {


    public InputField primaryInputField;
    public InputField secondaryInputField;
    public InputField primaryInputFieldNumber;
    public InputField secondaryInputFieldNumber;
    public GameObject PlayerTypeSaveObject;

    public InputField socialiserValueInput;
    public InputField mastermindValueInput;
    public InputField achieverValueInput;
    public InputField conquerorValueInput;
    public InputField survirorValueInput;
    public InputField daredevilValueInput;
    public InputField seekerValueInput;


    public playerResults[] playerresults;

    public string primaryType;
    public string secondaryType;   
   
    public void StartGame()
    {
        playerresults[0].value =int.Parse(socialiserValueInput.text);
        playerresults[2].value = int.Parse(mastermindValueInput.text);
        playerresults[1].value = int.Parse(achieverValueInput.text);
        playerresults[4].value = int.Parse(conquerorValueInput.text);
        playerresults[5].value = int.Parse(survirorValueInput.text);
        playerresults[6].value = int.Parse(daredevilValueInput.text);
        playerresults[3].value = int.Parse(seekerValueInput.text);

        CalculateHighest2();             
    }

    public void CalculateHighest2()
    {
        int[] results = new int[] { playerresults[0].value, playerresults[1].value, playerresults[2].value, playerresults[3].value, playerresults[4].value, playerresults[5].value, playerresults[6].value };
        Array.Sort(results);
        foreach(playerResults a in playerresults)
        {
            if (a.value == results[6])
            {
                a.first = true;
                primaryType = a.type;
            }
            if (a.value == results[5])
            {
                a.second = true;
                secondaryType = a.type;
            }
        }
        
    }   

}

