using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Moveable))]
public class ForwardMove : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void Update()
    {
        moveable.setDirection(transform.up);
    }
}
