using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerTicTacToe : MonoBehaviour
{
    public int beardLevel = 0;

    [SerializeField] private BoxTicTacToe[] arrayTT;
    [SerializeField] private Button[] buttBoxes;
    public Sprite imgWhite, imgX, imgO;
    [SerializeField] private Image playerO, playerX, charcter;
    [SerializeField] private Sprite[] mainCharacter;



    // o = false        x = true
    // mc is o
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

        if (WonCheck(StateTTT.playerO))
        {
            beardLevel++;
            WonEvent();
        }

        else if (WonCheck(StateTTT.playerX) & beardLevel >= 0)
        {
            beardLevel = beardLevel - 1;
            WonEvent();
        }

        for (int i = 0; i< arrayTT.Length; i++)
        {
            arrayTT[i].SetImageBasedOnState(StateTTT.white);
            buttBoxes[i].interactable = true;
        }

        switch (beardLevel)
        {
            case 0:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case 1:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case 2:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case 3:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case 4:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case 5:
                charcter.sprite = mainCharacter[beardLevel];
                break;

            case -1:
                charcter.sprite = mainCharacter[6];
                break;

        }
        
    }



    public bool WonCheck(StateTTT player)
    {
        bool wonOrNot = false;

        int[,] checkMe = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

        //checkMe 2d array listing all possible solutions to win the game

        for (int i=0; i<8; i++)
        {
            if (boxState[checkMe[i,0]]== player & boxState[checkMe[i, 1]] == player & boxState[checkMe[i, 2]] == player )
            {
                wonOrNot = true;
            }
        }

        return wonOrNot;
    }



    public void WonEvent()
    {
        for(int i=0; i<arrayTT.Length; i++)
        {
            buttBoxes[i].interactable = false;
        }
    }

    //void DrawCheck()
    //{
    //    bool xWon, oWon, full;

    //   full= false;

    //    for (int i = 0; i < boxState.Length; i++)
    //    {
    //        if (boxState[i] == StateTTT.white)
    //        {
    //            full = true;
    //        }
    //    }

    //    xWon = WonCheck(TTTState.X);
    //    oWon = WonCheck(TTTState.O);

    //    if (!xWon & !oWon & full){

    //    }
    //}
}
