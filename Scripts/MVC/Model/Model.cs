using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    SceneController sceneController;
    AdditionalGameController additionalGameController;
    ActionView actionView;
    [SerializeField] BaseView View;

    private void Awake()
    {
        sceneController = new SceneController();
        additionalGameController = new AdditionalGameController();
        actionView = new ActionView(sceneController, additionalGameController);
        View.Init(actionView);
    }
}
