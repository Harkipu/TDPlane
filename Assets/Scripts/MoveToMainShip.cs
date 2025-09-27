using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveToMainShip : MonoBehaviour
{

    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void Start()
    {
        moveable.setDirection(getDirection());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 getDirection()
    {
        Vector3 dir;
        dir = GMCode.GameManager.GetInstance().getPlayerPosition() - transform.position;
        dir = dir.normalized; 

        return dir;
    }
}
