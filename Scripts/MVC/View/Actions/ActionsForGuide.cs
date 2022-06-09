using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionsForGuide
{
    public UnityAction OpenGuide;
    public UnityAction CloseGuide;
    public UnityAction NextPage;
    public UnityAction PrevPage;

    GuideController guideController;
    public ActionsForGuide(GuideController _guideController)
    {
        guideController = _guideController;
    }

    public void SubscribeMethods()
    {
        OpenGuide += guideController.OpenGuide;
        CloseGuide += guideController.CloseGuide;
        NextPage += guideController.NextPage;
        PrevPage += guideController.PrevPage;
    }
}
