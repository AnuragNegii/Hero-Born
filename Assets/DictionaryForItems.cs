using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryForItems : MonoBehaviour
{
    Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    {   {"Potions", 5}, //{key, value}
        {"Antidode", 7},
        { "Aspirin", 1}
    };
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Items : {0 }", ItemInventory.Count);
    foreach(KeyValuePair<string, int> kvp in ItemInventory)
    {
        Debug.LogFormat("Item {0}: - {1}g", kvp.Key, kvp.Value);
    }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
