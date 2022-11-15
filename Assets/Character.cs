using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Character
{
    public string name;
    public int exp = 0;

    public Character(string name)
    {
        this.name = name;
    }
        public Character()
    {
       name = "Not assigned";
    }
    public void PrintStatsInfo(){

        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }
}