using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController
{
    private Button customButton;

    public ButtonController(Button _customButton)
    {
        customButton = _customButton;
    }
    public void SubscribeButtonToAction(UnityAction _customAction)
    {
        customButton.onClick.AddListener(_customAction);
    }
    public void Unsubscribe()
    {
        customButton.onClick.RemoveAllListeners();
    }
}
