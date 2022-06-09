using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController
{
    private Button cusatomButton;

    public ButtonController(Button _customButton)
    {
        cusatomButton = _customButton;
    }

    public void SubscribeButtonToAction(UnityAction _customAction)
    {
        cusatomButton.onClick.AddListener(_customAction);
    }
    public void Unsubscribe()
    {
        cusatomButton.onClick.RemoveAllListeners();
    }
}
