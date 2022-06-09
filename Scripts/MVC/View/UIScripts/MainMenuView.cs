using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : CustomUIView
{
    [SerializeField] Button startButton;
    [SerializeField] Button moreGamesButton;
    [SerializeField] Button quiteButton;
    public override void InitButtons(ActionView actionController)
    {
        if (startButton)
        {
            ButtonController startButtonCtrlr = CreateCustomButton(startButton);
            startButtonCtrlr.SubscribeButtonToAction(actionController.StartGame);
        }
        if (moreGamesButton)
        {
            ButtonController moreGamesButtonCtrlr = CreateCustomButton(startButton);
            moreGamesButtonCtrlr.SubscribeButtonToAction(actionController.MoreGamesLink);
        }
        if (quiteButton)
        {
            ButtonController quiteButtonCtrlr = CreateCustomButton(startButton);
            quiteButtonCtrlr.SubscribeButtonToAction(actionController.QuiteGame);
        }
    }
}
