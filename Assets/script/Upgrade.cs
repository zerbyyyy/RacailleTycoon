using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public PriceManager priceManager;
    public MoneyManager moneyManager;

    public int priceUpgrade = 1500;

    public void BuyUpgrade()
    {
        Debug.Log("Amélioration en cours...");
        if (moneyManager.moneyAmount >= priceUpgrade)
        {
            AcheterUpgrade();
            priceManager.priceAmount = 2000;

        }
        else
        {
            // Gérer le cas où le joueur n'a pas assez d'argent
            Debug.Log("Fonds insuffisants!");
        }
    }

    private void AcheterUpgrade()
    {
        // Logique pour effectuer l'achat
        moneyManager.moneyAmount -= priceUpgrade;
        Debug.Log("Amélioration effectuée!");
        // Ajoutez ici la logique pour ce que vous achetez (par exemple, incrémentez quelque chose)
    }
}
