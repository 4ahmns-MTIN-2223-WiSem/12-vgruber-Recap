using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangerScript : MonoBehaviour
{
    public GameObject theColored;
    public GameObject[] buttons;
    public bool[] buttonNumber;
    bool pressedButs = false;
    public GameObject magicButton;

    private void CheckButtons()
    {
        
        if (buttonNumber[0] && buttonNumber[1] && buttonNumber[2] && !pressedButs)
        {
            magicButton.SetActive(true);
            pressedButs = true;

        }
    }

    

    public void ColorChangerMan(int btn)
    {
        theColored.GetComponent<Image>().color = Random.ColorHSV();

        switch (btn)
        {

            case 1:
                if (!buttonNumber[0])
                {
                    buttonNumber[0] = true;
                    Debug.Log("btn 1 " + buttonNumber[0]);
                }
                break;

            case 2:
                if (!buttonNumber[1])
                {
                    buttonNumber[1] = true;
                    Debug.Log("btn 2 " + buttonNumber[1]);
                }
                break;

            case 3:
                if (!buttonNumber[2])
                {
                    buttonNumber[2] = true;
                    Debug.Log("btn 3 " + buttonNumber[2]);
                }
                break;
        }

        CheckButtons();

    } 


}
