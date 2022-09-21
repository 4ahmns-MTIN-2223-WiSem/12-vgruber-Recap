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

    public void ColorChangerMan()
    {
        theColored.GetComponent<Image>().color = Random.ColorHSV();

        if (EventSystem.current.currentSelectedGameObject == buttons[0])
        {
            if (buttons[0])
            {
                if (buttonNumber[0] <= 0)
                {
                    buttonNumber[0]++;
                    Debug.Log(buttonNumber[0]);

                }
            }
        }

        if (EventSystem.current.currentSelectedGameObject == buttons[1])
        {
            if (buttons[1])
            {
                if (buttonNumber[1] <= 0)
                {
                    buttonNumber[1]++;
                    Debug.Log(buttonNumber[1]);
                }
            }
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
