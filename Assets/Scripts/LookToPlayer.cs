using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookAt();
    }

    void lookAt()
    {
        if (GMCode.GameManager.GetInstance().activePlayer != null)
        {
            transform.up = GMCode.GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }
    }
}
