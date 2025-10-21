using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : MonoBehaviour
{
    public void addComponentToObject(GameObject go) 
    {
        go.AddComponent<WeaponUpgrade>();
        go.GetComponent<WeaponSetController>().weaponUpgradeCheck();
    }
    
}
