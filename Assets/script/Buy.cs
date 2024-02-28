using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public MoneyManager moneyManager;

    public PriceManager priceManager;
    public int coutDeLachat = 100;
    
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
            // Gérer le cas où le joueur n'a pas assez d'argent
            Debug.Log("Fonds insuffisants!");
        }
    }

    private void AcheterObjet()
    {
        // Logique pour effectuer l'achat
        moneyManager.moneyAmount -= coutDeLachat;
        Debug.Log("Achat effectué!");
        // Ajoutez ici la logique pour ce que vous achetez (par exemple, incrémentez quelque chose)
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
