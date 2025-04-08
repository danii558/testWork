using UnityEngine;
using UnityEngine.UI;

public class wallet : MonoBehaviour
{
    [SerializeField] private int _points;
    [Header("UI")]
    public Text pointText;


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
    }

    public void BuyOnShop(int changePoints)
    {
        if(_points >= changePoints)
        {
            _points -= changePoints;
            pointText.text = _points.ToString();
            prize();
        } else
        {
            Debug.Log("Error! You dont have a money");
        }
    }

    private void prize()
    {
        clickButton.singleton.changeClicksCount(1);
    }
}
