using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseView : MonoBehaviour
{
    [SerializeField] CustomUIView MeinMenuView;
    [HideInInspector] public ActionView ActionView;
    
    public void Init(ActionView _actionView)
    {
        ActionView = _actionView;
        ActionView.SubscribeMethods();
        MeinMenuView.InitButtons(ActionView);
    }
}
