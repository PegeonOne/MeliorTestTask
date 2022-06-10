using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : BaseModel
{
    [SerializeField] GameView GameView;
    [SerializeField] GuideUi GuideView;
    [SerializeField] BankView BankView;
    [SerializeField] ArchersController ArchersController;
    [SerializeField] GameObject GuideObject;
    [SerializeField] GameObject GameMenu;
    [SerializeField] Transform GuideBook;
    ActionsForGuide actionsForGuide;
    ActionsForBanking actionsForBanking;
    GuideController guideController;
    BankController bankController;
    private void Awake()
    {
        //scene init
        sceneController = new SceneController();
        additionalGameController = new AdditionalGameController();
        actionView = new ActionView(sceneController, additionalGameController);
        actionView.SubscribeMethods();
        GameView.InitButtons(actionView);
        //guide init
        guideController = new GuideController(GuideObject, GuideBook, GameMenu);
        actionsForGuide = new ActionsForGuide(guideController);
        actionsForGuide.SubscribeMethods();
        GuideView.InitGuide(actionsForGuide);
        //bank init
        actionsForBanking = new ActionsForBanking();
        bankController = new BankController(10000);
        ArchersController.BankController = bankController;
        BankView.InitBanking(actionsForBanking, ArchersController, bankController);
    }
}
