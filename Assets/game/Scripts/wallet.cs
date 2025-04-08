using System;
using UnityEngine;
using UnityEngine.UI;

public class wallet : MonoBehaviour
{
    [SerializeField] private int _points;
    [Header("UI")]
    public Text pointText;

    public event Action Buy;

    public static wallet singleton;

    private void Awake()
    {
        pointText.text = _points.ToString();

        singleton = this;
        //DontDestroyOnLoad(singleton);
    }

    public void ChangePoints(int ChangeWallet)
    {
        _points += ChangeWallet;
        pointText.text = _points.ToString();
        shop._nowPoints = _points;
    }
    public void TakeAwayPoints(int changeWallet)
    {
        _points -= changeWallet;
        pointText.text = _points.ToString();
        shop._nowPoints = _points;
    }

    public void BuyOnShop(int changePoints)
    {
        Buy?.Invoke();
    }

    public int ReturnPoints()
    {
        return _points;
    }
}
