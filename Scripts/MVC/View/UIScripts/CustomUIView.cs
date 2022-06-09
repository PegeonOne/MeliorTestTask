using UnityEngine;
using UnityEngine.UI;

public abstract class CustomUIView : MonoBehaviour
{
    public abstract void InitButtons(ActionView actionController);

    protected ButtonController CreateCustomButton(Button _button)
    {
        ButtonController newCustomButton = new ButtonController(_button);
        return newCustomButton;
    }
    
}
