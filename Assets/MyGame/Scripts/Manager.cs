using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public Button b1, b2, b3, btnNext;
    bool bt1, bt2, bt3;

    // Start is called before the first frame update
    void Start()
    {
        b1.GetComponent<Image>().color = Color.green;
        b2.GetComponent<Image>().color = Color.blue;
        b3.GetComponent<Image>().color = Color.red;

        btnNext.interactable = false;
    }

    public void ChangeColor(int btn)
    {
        switch(btn)
        {
            case 1:
                b1.GetComponent<Image>().color = Random.ColorHSV();
                bt1 = true;
                break;


            case 2:
                b2.GetComponent<Image>().color = Random.ColorHSV();
                bt2 = true;
                break;

            case 3:
                b3.GetComponent<Image>().color = Random.ColorHSV();
                bt3 = true;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(bt1&& bt2 && bt3 && (btnNext.interactable == false)){
            btnNext.interactable = true;
            Debug.Log("so often");
        }
    }
}
