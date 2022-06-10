using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankView : CustomUIView
{
    [SerializeField] Text CoinsDisplay;
    [SerializeField] Text ArchersCountDisplay;
    [SerializeField] Button BuyButton;
    [SerializeField] Button UpgradeButton;
    BankController bankController;
    ArchersController archerController;
    string text = "Coins: ";
    public override void InitButtons(ActionView actionController)
    {
        
    }
    public void InitBanking(ActionsForBanking _actionsForBanking, ArchersController _archersController, BankController _bankController)
    {
        bankController = _bankController;
        archerController = _archersController;
        if (BuyButton)
        {
            ButtonController buyBut = CreateCustomButton(BuyButton);
            _actionsForBanking.BuyArcher += _archersController.AddArcher;
            buyBut.SubscribeButtonToAction(_actionsForBanking.BuyArcher);
        }
        if (UpgradeButton)
        {
            ButtonController upgradeBut = CreateCustomButton(UpgradeButton);
            _actionsForBanking.UpgradeArchers += _archersController.UpgradeArcher;
            upgradeBut.SubscribeButtonToAction(_actionsForBanking.UpgradeArchers);
        }
    }
    private void Update()
    {
        CoinsDisplay.text = text + bankController.Count;
        ArchersCountDisplay.text = archerController.archersCount + "/3";
    }
}
