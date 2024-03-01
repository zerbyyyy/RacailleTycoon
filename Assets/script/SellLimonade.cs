using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellLimonade : MonoBehaviour
{
    public MoneyManager moneyManager;
    public PriceManager priceManager;

    public int argent = 10;

    public void Upmoney()
    {
        moneyManager.moneyAmount += argent;
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

    void Start()
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
