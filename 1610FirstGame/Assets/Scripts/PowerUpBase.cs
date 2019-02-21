using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    public float Value = 10.5f;

    void OnEnable ()
    {

    }

    public void OnPowerUp(float addValue)
    {
        Value += addValue;
    }
}
