using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public MoneyManager moneyManager;
    public PriceManager priceManager;
    public int coutDeLachat = 100;
    public int argent = 10;
    public Button buttonBuy;
    public bool isAuto = true;
    
    public void BuyItem()
    {
        Debug.Log("Achat en cours...");
        if (moneyManager.moneyAmount >= coutDeLachat)
        {
            AcheterObjet();
            priceManager.priceAmount = 1000;
        }
        else
        {
            Debug.Log("Fonds insuffisants!");
        }
    }

    private void AcheterObjet()
    {
        moneyManager.moneyAmount -= coutDeLachat;
        Debug.Log("Achat effectué!");
    }

    public IEnumerator AutoUpmoney()
    {
        if (buttonBuy != null)
        {
            buttonBuy.onClick.AddListener(() =>
            {
                Debug.Log("Auto désactivé");
                isAuto = true;
            });
        }
        else
        {
            Debug.LogError("Bouton non trouvé!");
            isAuto = false;
        }
        while (isAuto)
        {
            Debug.Log("Auto");
            yield return new WaitForSeconds(1);
            moneyManager.moneyAmount += argent;
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
        StartCoroutine(AutoUpmoney());
    }
}
