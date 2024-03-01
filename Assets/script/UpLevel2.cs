using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpLevel2 : MonoBehaviour
{
    public GameObject level2;
    public Button votreBouton;

    public MoneyManager moneyManager;

    private void Start()
    {
        votreBouton.onClick.AddListener(OnBoutonClique);
    }

    public void OnBoutonClique()
    {
        if (level2 != null)
        {
            Destroy(level2);
            Acheterniveau();
        }
        else
        {
            Debug.LogWarning("Aucun GameObject à retirer spécifié !");
        }
    }

    public void Acheterniveau()
    {
        if (moneyManager.moneyAmount >= 2000)
        {
            moneyManager.moneyAmount -= 2000;
            level2.SetActive(true);
            Debug.Log("Achat effectué!");
        }
        else
        {
            Debug.Log("Fonds insuffisants!");
        }
    }
}
