using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ScriptableIntegers coin;

    public void OnGain() 
    {
        coin.value += 1;
    }
}
