using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : CustomUIView
{

    [SerializeField] Button BackToMenuButton;
    [SerializeField] Button PauseButton;
    
    public override void InitButtons(ActionView actionController)
    {       
        if (BackToMenuButton)
        {
            ButtonController backToMenuCtrlr = CreateCustomButton(BackToMenuButton);
            backToMenuCtrlr.SubscribeButtonToAction(actionController.BackToMainMenu);
        }
        if (PauseButton)
        {
            ButtonController pauseCtrlr = CreateCustomButton(PauseButton);
            pauseCtrlr.SubscribeButtonToAction(actionController.Pause);
        }      
    }
}
