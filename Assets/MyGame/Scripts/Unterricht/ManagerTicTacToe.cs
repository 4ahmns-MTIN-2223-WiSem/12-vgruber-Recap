using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerTicTacToe : MonoBehaviour
{

    [SerializeField] private BoxTicTacToe[] arrayTT;
    public Sprite imgWhite, imgX, imgO;
    [SerializeField] private Image playerO, playerX;

    // o = false        x = true
    public bool player1;

    public StateTTT playerState;
    public StateTTT[] boxState;
    

    // Start is called before the first frame update
    void Start()
    {
        player1 = false;
        playerState = StateTTT.playerO;
        ShowActivePlayer1(player1);

        for(int i = 0; i<boxState.Length; i++)
        {
            boxState[i] = StateTTT.white;
        }
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

    void EmptyCheck()
    {

    }

    bool WonCheck(TTTState player)
    {
        bool wonOrNot = false;

        int[,] checkMe = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

        for (int i=0; i<8; i++)
        {
            if (boxState[checkMe[i,0]]== playerState & boxState[checkMe[i, 1]] == playerState & boxState[checkMe[i, 2]] == playerState )
            {
                wonOrNot = true;
            }
        }

        return wonOrNot;
    }

    void DrawCheck()
    {
        bool xWon, oWon, white;

        white = false;

        xWon = WonCheck(TTTState.X);
        oWon = WonCheck(TTTState.O);

        if (!xWon & !oWon & white){

        }
    }
}
