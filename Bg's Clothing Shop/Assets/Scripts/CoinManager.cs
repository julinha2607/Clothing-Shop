using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{

    public Text coinText;
    public int moneyTotal = 100;

    private void Start()
    {
        

    }

    private int GetMoneyTotal()
    {
        return moneyTotal;
    }

    private void Update()
    {
        GetMoneyTotal();
        coinText.text = moneyTotal.ToString();

    }


}
