using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Text MoneyText;
    [SerializeField] Text BankMoneyText;

    [SerializeField] private GameObject Deposit;
    [SerializeField] private GameObject Withdraw;


    private void Awake()
    {
        MoneyText.text = "현금\n\n" + DataController.GetInstance().Money + " (원)";
        BankMoneyText.text = $"{DataController.GetInstance().BankMoney}";
    }

    private void Start()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
    }

    public void Update()
    {
        MoneyText.text = "현금\n\n" + DataController.GetInstance().Money + " (원)";
        BankMoneyText.text = $"{DataController.GetInstance().BankMoney}";
    }
}