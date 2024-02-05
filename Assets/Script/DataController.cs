using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController Instance;
    public static DataController GetInstance()
    {
       if (Instance == null)
        {
            Instance = FindObjectOfType<DataController>();
            if (Instance == null)
            {
                GameObject container = new GameObject("DataController");
                Instance = container.AddComponent<DataController>();
            }
        }
        return Instance;
    }



    [HideInInspector]
    public int BankMoney
    {
        get
        {
            return PlayerPrefs.GetInt("BankMoney");
        }
        set
        {
            PlayerPrefs.SetInt("BankMoney", value);
        }
    }
    [HideInInspector]
    public int Money
    {
        get
        {
            return PlayerPrefs.GetInt("Money",100000);
        }
        set
        {
            PlayerPrefs.SetInt("Money", value);
        }
    }
}
