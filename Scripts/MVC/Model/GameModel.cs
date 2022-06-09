using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : BaseModel
{
    [SerializeField] GameView GameView;
    [SerializeField] GuideUi GuideView;
    [SerializeField] GameObject GuideObject;
    [SerializeField] GameObject GameMenu;
    [SerializeField] Transform GuideBook;
    ActionsForGuide actionsForGuide;
    GuideController guideController;
    private void Awake()
    {
        sceneController = new SceneController();
        additionalGameController = new AdditionalGameController();
        actionView = new ActionView(sceneController, additionalGameController);
        actionView.SubscribeMethods();
        guideController = new GuideController(GuideObject, GuideBook, GameMenu);
        actionsForGuide = new ActionsForGuide(guideController);
        actionsForGuide.SubscribeMethods();
        GuideView.InitGuide(actionsForGuide);
        GameView.InitButtons(actionView);
    }
}
