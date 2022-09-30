using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StateTTT
{
    white,
    playerX,
    playerO
}

public class BoxTicTacToe : MonoBehaviour
{
    public StateTTT myState;
    public int id;
    private Image myImage;
    private ManagerTicTacToe myManager;
    
    

    // Start is called before the first frame update
    void Start()
    {
        myState = StateTTT.white;
        myImage = gameObject.GetComponent<Image>();
        myManager = FindObjectOfType<ManagerTicTacToe>();

        SetImageBasedOnState(myState);
    }

    public void PressMe()
    {

        if (myManager.WonCheck(StateTTT.playerO))
        {
            myManager.beardLevel++;
            myManager.WonEvent();
        }

        else if (myManager.WonCheck(StateTTT.playerX) & myManager.beardLevel >= 0)
        {
            myManager.beardLevel = myManager.beardLevel - 1;
            myManager.WonEvent();
        }

        else
        {

            // change state

            if (myManager.player1)
            {
                myState = StateTTT.playerX;
                SetImageBasedOnState(myState);

            }
            else
            {
                myState = StateTTT.playerO;
                SetImageBasedOnState(myState);

            }
            Debug.Log(gameObject.name);


            myManager.player1 = !myManager.player1;
            if (myManager.player1)
            {
                myManager.playerState = StateTTT.playerX;
            }

            else
            {
                myManager.playerState = StateTTT.playerO;
            }
            myManager.ShowActivePlayer1(myManager.player1);

        }
    }

    public void SetImageBasedOnState(StateTTT state)
    {
        switch (state)
        {
            case StateTTT.white:
                myImage.sprite = myManager.imgWhite;
                myManager.boxState[id] = StateTTT.white;
                break;

            case StateTTT.playerO:
                myImage.sprite = myManager.imgO;
                myManager.boxState[id] = StateTTT.playerO;
                break;
            case StateTTT.playerX:
                myImage.sprite = myManager.imgX;
                myManager.boxState[id] = StateTTT.playerX;
                break;
        }
    }
}
