
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TTTState
{
    W,
    O,
    X
}


public class TTTElement : MonoBehaviour
{
    public TTTState BoxState = TTTState.W;

    void Update()
    {

        if (BoxState == TTTState.X){
            gameObject.GetComponent<Image>().color = Color.yellow;
            gameObject.GetComponent<Button>().interactable = false;
        }

        if (BoxState == TTTState.O)
        {
            gameObject.GetComponent<Image>().color = Color.blue;
            gameObject.GetComponent<Button>().interactable = false;
        }

        if (BoxState == TTTState.W)
        {
            gameObject.GetComponent<Image>().color = Color.white;
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
