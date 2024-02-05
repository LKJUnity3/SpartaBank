using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BankButton : MonoBehaviour
{
    [SerializeField] GameObject Impossible;
    [SerializeField] InputField MoneyField;

    private void Awake()
    {
        Impossible = GameObject.Find("CancelPannel");
    }
    private void Start()
    {
        Impossible.SetActive(false);
    }
    public void OnClick()
    {
        int Money = int.Parse(gameObject.name);
        OnMath(Money);
    }

    public void OnSelfClick()
    {
        int Money = int.Parse(MoneyField.text);
        OnMath(Money);
    }

    public void OnMath(int Money)
    {
        if (gameObject.transform.parent.name == "Deposit")
        {
            if (DataController.GetInstance().Money >= Money)
            {
                DataController.GetInstance().Money -= Money;
                DataController.GetInstance().BankMoney += Money;
            }
            else
            {
                Impossible.SetActive(true);
            }
        }
        else if (gameObject.transform.parent.name == "Withdraw")
        {
            Debug.Log(Money);
            if (DataController.GetInstance().BankMoney >= Money)
            {
                DataController.GetInstance().BankMoney -= Money;
                DataController.GetInstance().Money += Money;
            }
            else
            {
                Impossible.SetActive(true);
            }
        }
    }

    public void OnCancel()
    {
        Impossible.SetActive(false);
    }
}


