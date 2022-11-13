using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestExperiment : MonoBehaviour
{
    public bool pureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "car";
    public void OpenTreasureChamber()
    {
    if(pureOfHeart == true && RareItem == "car")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
