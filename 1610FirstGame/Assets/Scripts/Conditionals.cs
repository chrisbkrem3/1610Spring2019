using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour
{

    public bool CanWalk;
    public int Number = 11;
    public string Password;


  
    void Update()
    {
        if (CanWalk)
        {
            print("True");
        }

        if (Number >= 10)
        {
            print("Greater");
        }
    }
}
