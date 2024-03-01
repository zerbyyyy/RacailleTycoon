using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class PriceManager : MonoBehaviour
{
    public TextMeshProUGUI priceText;

    public int priceAmount = 100;

    void Update()
    {
        priceText.text = $"{priceAmount}$";
    }
}
