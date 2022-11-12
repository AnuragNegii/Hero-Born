using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    public int CurrentGold = 32;
    public bool hasDungeonKey = false;
    public string weaponType = "Arcane Staff";
    void Start()
    {   
        int characterLevel = 5;
        Debug.Log(GenerateCharacter("Spike", characterLevel));
        thievery();
        if (!hasDungeonKey)
        {
            Debug.Log("you may not enter without the sacred key.");

        }

        if (weaponType != "Longsword")
        {
            Debug.Log("You don't appear to have the right type of a weapon");
        }
    }

public int GenerateCharacter(string name, int level)
{
        Debug.LogFormat("Character Name: {0}, Character Level: {1}", name, level);
        return level += 5;
}

   public void thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("you are rolling in it!");
        }
        else if (CurrentGold<15)
        {
            Debug.Log("Not much to steal");
        }
        else
        {
            Debug.Log("your purse is in the sweet spot");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
