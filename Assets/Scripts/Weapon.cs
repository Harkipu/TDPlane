using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float firerate;
    private float timer = 0;
    public PoolObjectType type;
    public List<float> fireRateModifiers;

    void Start()
    {
        
    }

    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    public void shoot()
    {
        if (timer == 0f)
        {
            ObjectPooling.GetInstance().requestObject(type).activate(transform.position,transform.rotation);
            timer = firerate / getFireRateModifier();
        }
    }

    private float getFireRateModifier()
    {
        float mod = 1;
        foreach(float f in fireRateModifiers)
        {
            mod += f;
        }
        return mod;
    }

    internal void addFireRateModifier(float modifier) 
    {
        fireRateModifiers.Add(modifier);
    }


    internal void clearModifier() 
    {
        fireRateModifiers.Clear();
    }

    internal void removeFireRateModifier(float modifier) 
    {
        fireRateModifiers.Remove(modifier);
    }

}
