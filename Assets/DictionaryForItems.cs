using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryForItems : MonoBehaviour
{
    Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    {   {"Potions", 5},
        {"Antidode", 8},
        { "Aspirin", 1}
    };
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Items : {0 }", ItemInventory.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
