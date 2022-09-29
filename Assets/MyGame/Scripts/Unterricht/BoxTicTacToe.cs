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
    StateTTT myState;
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
        myManager.ShowActivePlayer1(myManager.player1);
    }

    public void SetImageBasedOnState(StateTTT state)
    {
        switch (state)
        {
            case StateTTT.white:
                myImage.sprite = myManager.imgWhite;
                break;

            case StateTTT.playerO:
                myImage.sprite = myManager.imgO;
                break;
            case StateTTT.playerX:
                myImage.sprite = myManager.imgX;
                break;
        }
    }
}
