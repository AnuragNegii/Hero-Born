using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseCheck : MonoBehaviour
{
    string CharacterAction = "Attack";

    // Start is called before the first frame update
    void Start()
    {
        PrintCharacterAction();
    }

    public void PrintCharacterAction()
    {
        switch(CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion Sent.");
                break;
            case "Attack":
                Debug.Log("To Arms!");
                break;
            default:
                Debug.Log("Shields Up");
                break;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
