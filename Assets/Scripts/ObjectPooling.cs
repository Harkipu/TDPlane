using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    private static ObjectPooling instance;

    public int size;
    public GameObject[] prefabs;

    public List<PoolObject> poolObjects;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static ObjectPooling GetInstance() 
    {
        return instance;
    }

    void Start()
    {
        instantiateObjects();
    }

    private void instantiateObjects()
    {
        poolObjects = new List<PoolObject>();
        for (int i = 0; i < size; i++)
        {
            foreach (GameObject go in prefabs)
            {
                poolObjects.Add(Instantiate(go, transform).GetComponent<PoolObject>());
            }
        }
    }

    public PoolObject requestObject(PoolObjectType type)
    {
        foreach (PoolObject po in poolObjects)
        {
            if (po.type == type && !po.isActive())
            {
                return po;
            }
        }
        return null;
    }

    public void deactivateAllObject() 
    {
        foreach(PoolObject po in poolObjects) 
        {
            po.deactivate();
        }
    }
}
