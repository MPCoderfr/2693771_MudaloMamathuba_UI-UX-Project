using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletScript : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public int moneyCounter ;
    

    public void Start()
    {
        moneyCounter = 100;
        ConvertToText();
    }

    public void ConvertToText()
    {
        moneyText.text = "Money : $   " + moneyCounter.ToString();
    }


}
