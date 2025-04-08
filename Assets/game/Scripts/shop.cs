using UnityEngine;

public class shop : MonoBehaviour
{
    [SerializeField] private int price;
    public void Buy()
    {
        wallet.singleton.BuyOnShop(price);
    }
}
