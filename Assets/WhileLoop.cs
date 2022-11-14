using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int PlayerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        HealthStatus();
    }

    public void HealthStatus(){
        while(PlayerLives > 0){
            Debug.Log("Player is still alive!");
            PlayerLives--;
        }Debug.Log("Player is KO'd.....");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
