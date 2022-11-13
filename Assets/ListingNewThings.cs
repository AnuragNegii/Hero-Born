using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListingNewThings : MonoBehaviour
{
    List<string> QuestPartyMembers = new List<string> { "Grim the Barbarian",
        "Merlin the Wise",
    "Sterling the Knight"};
    // Start is called before the first frame update
    void Start()
    {
        QuestPartyMembers.Add("Craven the Necromancer");
        QuestPartyMembers.Insert(1, "Tanis the Thief");

        Debug.LogFormat("Party Member : {0}", QuestPartyMembers.Count);

        QuestPartyMembers.RemoveAt(0);
        Debug.LogFormat("Party Member : {0}", QuestPartyMembers.Count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
