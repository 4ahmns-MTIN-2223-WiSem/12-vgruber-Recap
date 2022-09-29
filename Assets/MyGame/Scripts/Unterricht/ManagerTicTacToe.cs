using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerTicTacToe : MonoBehaviour
{

    [SerializeField] private BoxTicTacToe[] arrayTT;
    public Sprite imgWhite, imgX, imgO;
    [SerializeField] private Image playerO, playerX;

public bool player1;

    // Start is called before the first frame update
    void Start()
    {
        player1 = false;
        ShowActivePlayer1(player1);
    }

    public void ShowActivePlayer1(bool isPlayer1)
    {
        if (isPlayer1)
        {
            playerO.color = Color.green;
            playerX.color = Color.white;

        }
        else
        {
            playerX.color = Color.green;
            playerO.color = Color.white;
        }
    }

    public void ResetBoard()
    {
        for(int i = 0; i< arrayTT.Length; i++)
        {
            arrayTT[i].SetImageBasedOnState(StateTTT.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
