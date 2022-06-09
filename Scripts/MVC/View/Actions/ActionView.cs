using UnityEngine;
using UnityEngine.Events;

public class ActionView
{
    public UnityAction StartGame;
    public UnityAction BackToMainMenu;
    public UnityAction MoreGamesLink;
    public UnityAction QuiteGame;
    public UnityAction Pause;
    public UnityAction AddArcher;
    public UnityAction UpgradeArcher;
    private SceneController sceneController;
    private AdditionalGameController additionalGameLogic;

    public ActionView(SceneController _sceneController, AdditionalGameController _additionalController)
    {
        sceneController = _sceneController;
        additionalGameLogic = _additionalController;
    }
    public void SubscribeMethods()
    {
        StartGame += sceneController.StartTheGame;
        BackToMainMenu += sceneController.BackToMenu;
        MoreGamesLink += additionalGameLogic.OpenLinkToGamesList;
        QuiteGame += additionalGameLogic.QuiteTheGame;
        Pause += additionalGameLogic.SetPause;
    }
}
