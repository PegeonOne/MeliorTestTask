using UnityEngine;
using UnityEngine.UI;

public class GuideUi : CustomUIView
{
    [SerializeField] Button OpenGuideBut;
    [SerializeField] Button CloseGuideBut;
    [SerializeField] Button NextPageBut;
    [SerializeField] Button PrevPageBut;
    public void InitGuide(ActionsForGuide guideActions)
    {
        if (OpenGuideBut)
        {
            ButtonController openCtrlr = CreateCustomButton(OpenGuideBut);
            openCtrlr.SubscribeButtonToAction(guideActions.OpenGuide);
        }
        if (CloseGuideBut)
        {
            ButtonController closeCtrlr = CreateCustomButton(CloseGuideBut);
            closeCtrlr.SubscribeButtonToAction(guideActions.CloseGuide);
        }
        if (NextPageBut)
        {
            ButtonController nextCtrlr = CreateCustomButton(NextPageBut);
            nextCtrlr.SubscribeButtonToAction(guideActions.NextPage);
        }
        if (PrevPageBut)
        {
            ButtonController prevCtrlr = CreateCustomButton(PrevPageBut);
            prevCtrlr.SubscribeButtonToAction(guideActions.PrevPage);
        }
    }
    public override void InitButtons(ActionView actionController)
    {
        throw new System.NotImplementedException();
    }
}
