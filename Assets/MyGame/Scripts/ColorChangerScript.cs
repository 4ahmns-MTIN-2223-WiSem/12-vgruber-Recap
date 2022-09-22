using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ColorChangerScript : MonoBehaviour
{
    public GameObject theColored;
    public GameObject[] buttons;
    public int[] buttonNumber;
    int pressedBut = 0;
    public GameObject magicButton;

    private void Update()
    {
       pressedBut = buttonNumber[0] + buttonNumber[1] + buttonNumber[2];

        if (pressedBut == 3)
        {
            magicButton.SetActive(true);
        }
    }

    public void ColorChangerMan(int btn)
    {
        theColored.GetComponent<Image>().color = Random.ColorHSV();

        switch (btn)
        {

            case 1:
                if (buttonNumber[0] <= 0)
                {
                    buttonNumber[0]++;
                    Debug.Log(buttonNumber[0]);
                }
                break;

            case 2:
                if (buttonNumber[1] <= 0)
                {
                    buttonNumber[1]++;
                    Debug.Log(buttonNumber[1]);
                }
                break;

            case 3:
                if (buttonNumber[2] <= 0)
                {
                    buttonNumber[2]++;
                    Debug.Log(buttonNumber[2]);
                }
                break;
        }

        

        

        if (EventSystem.current.currentSelectedGameObject == buttons[2])
        {
            if (buttons[2])
            {
                if (buttonNumber[2] <= 0)
                {
                    buttonNumber[2]++;
                    Debug.Log(buttonNumber[2]);
                }
            }
        }

    }

}
