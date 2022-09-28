using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerTTT : MonoBehaviour
{
    public TTTElement[] game;
    bool xTurn;

    void Start()
    {
        xTurn = true;
    }


    public void SelectedBox(int box)
    {
         if (xTurn)
        {
            game[box].GetComponent<TTTElement>().BoxState = TTTState.X;
            xTurn = false;
        }
        else
        {
            game[box].GetComponent<TTTElement>().BoxState = TTTState.O;
            xTurn = true;
        }
    }

    public void ResetTTT()
    {
        for (int i = 0; i < game.Length; i++)
        {
            game[i].GetComponent<TTTElement>().BoxState = TTTState.W;
        }
    }
}
