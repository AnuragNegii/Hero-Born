using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    int diceRoll = 7;
    int[] TopPlayerScore = { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        RollDice();
        Debug.Log(TopPlayerScore.Length);
        TopPlayerScore[1] = 4;
        Debug.Log(TopPlayerScore[1]);
    }
    public void RollDice()
    {
        switch(diceRoll)
        {
            case 7:

            case 15:
                Debug.Log("Mediocre Damage, not bad");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes Down");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
