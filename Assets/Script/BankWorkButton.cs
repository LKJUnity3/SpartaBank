using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankWorkButton : MonoBehaviour
{
    [SerializeField] protected GameObject Deposit;
    [SerializeField] protected GameObject Withdraw;
    [SerializeField] protected GameObject Bank;
    public void OnDepositClick()
    {
        Deposit.SetActive(true);
        Bank.SetActive(false);
    }

    public void OnWithdrawClick()
    {
        Withdraw.SetActive(true);
        Bank.SetActive(false);
    }

    public void OnBackClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Bank.SetActive(true);
    }
}
