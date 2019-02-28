using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;

    public bool OnBool;


    void Update()
    {
        if (OnBool)
        {
            OnEvent.Invoke();
        }
        else
        {
            OffEvent.Invoke();
        }
    }
}
