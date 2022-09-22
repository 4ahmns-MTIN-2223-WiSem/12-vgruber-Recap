using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public Button b1, b2, b3;

    // Start is called before the first frame update
    void Start()
    {
        b1.GetComponent<Image>().color = Color.green;
        b2.GetComponent<Image>().color = Color.blue;
        b3.GetComponent<Image>().color = Color.red;
    }

    public void ChangeColor(int btn)
    {
        switch(btn)
        {
            case 1:
                b1.GetComponent<Image>().color = Color.yellow;
                break;


            case 2:
                b2.GetComponent<Image>().color = Color.yellow;
                break;

            case 3:
                b3.GetComponent<Image>().color = Color.yellow;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
