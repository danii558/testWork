using UnityEngine;

public class shop : MonoBehaviour
{
    [SerializeField] private int price;

    public static int _nowPoints;

    private void Start()
    {
        wallet.singleton.Buy += OnBuy;
        _nowPoints = wallet.singleton.ReturnPoints();
    }

    public void OnBuy()
    {
        if (_nowPoints >= price)
        {
            wallet.singleton.TakeAwayPoints(price);
            Prize();
            Debug.Log(_nowPoints);
        } 
        else
        {
            Debug.Log("Error! You dont have a money");
            Debug.Log(_nowPoints);
        }
    }

    private void Prize()
    {
        clickButton.singleton.changeClicksCount(1);
    }
}
