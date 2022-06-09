using UnityEngine;

public class MainMenuModel : BaseModel
{
    [SerializeField] MainMenuView view;
    private void Awake()
    {
        sceneController = new SceneController();
        additionalGameController = new AdditionalGameController();
        actionView = new ActionView(sceneController, additionalGameController);
        actionView.SubscribeMethods();
        view.InitButtons(actionView);
    }
}
