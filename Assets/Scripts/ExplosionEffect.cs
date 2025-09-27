using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    public void showExplosion() 
	{
        ObjectPooling.GetInstance().requestObject(PoolObjectType.EXPLOSION).activate(transform.position, Quaternion.identity);
    }
}
