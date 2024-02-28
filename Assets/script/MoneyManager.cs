using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    public int moneyAmount = 100;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = $"Argent : {moneyAmount}";
    }
}
