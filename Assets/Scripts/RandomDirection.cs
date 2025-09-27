using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class RandomDirection : MonoBehaviour
{

    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void Start()
    {
        moveable.setDirection(0, -1);
    }

    // private float randomDirection()
    // {
    //     return Random.Range(-1f, 1);
    // }
}
