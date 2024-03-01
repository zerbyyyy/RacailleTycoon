using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public PriceManager priceManager;
    public MoneyManager moneyManager;

    public SellLimonade sellLimonade;

    public int priceUpgrade = 500;

    public void BuyUpgrade()
    {
        Debug.Log("Amélioration en cours...");
        if (moneyManager.moneyAmount >= priceUpgrade)
        {
            AcheterUpgrade();
            priceManager.priceAmount = 2000;
            sellLimonade.argent = 20;

        }
        else
        {
            Debug.Log("Fonds insuffisants!");
        }
    }

    private void AcheterUpgrade()
    {
        moneyManager.moneyAmount -= priceUpgrade;
        Debug.Log("Amélioration effectuée!");
    }
}
