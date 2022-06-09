using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalGameController 
{
    public void QuiteTheGame()
    {
        Application.Quit();
    }
    public void OpenLinkToGamesList()
    {
        //SomeActions
    }
    public void SetPause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }       
    }
}
