using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPlayer : MonoBehaviour
{
    public void gameOver() 
	{
        GMCode.GameManager.GetInstance().gameOver();
    }
}
