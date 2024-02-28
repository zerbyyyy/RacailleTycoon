using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellLimonade : MonoBehaviour
{
    public MoneyManager moneyManager;
    public PriceManager priceManager;

    public void Upmoney()
    {
        moneyManager.moneyAmount += 10;

        if (moneyManager.moneyAmount >= 1000)
        {
            moneyManager.moneyAmount = 1000;
            Debug.Log("Vous ne pouvez pas avoir plus de 1500$! veuillez acheter des améliorations!");
        }
    }
    void Update()
    {
        if (moneyManager != null)
        {
            moneyManager = FindObjectOfType<MoneyManager>();
        }
        else
        {
            Debug.LogError("MoneyManager non trouvé!");
        }
    }
}
