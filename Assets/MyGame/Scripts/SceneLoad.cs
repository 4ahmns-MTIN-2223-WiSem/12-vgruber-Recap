using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
   
   public void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }
}
