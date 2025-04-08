using UnityEngine;

public class clickButton : MonoBehaviour
{
    [SerializeField] private GameObject _thisBut;
    [SerializeField] private int _howChange;
    private int _allClicks;
    public static clickButton singleton;

    private void Awake()
    {
        singleton = this;
    }
    public void ClickerButton()
    {
        wallet.singleton.ChangePoints(_howChange);
        _allClicks++;

        // this set max low
        if(_allClicks == 10)
        {
            _allClicks = 0;
            if (_thisBut.transform.localScale.x > .1f)
            {
                lessing();
            }
        }

    }

    private void lessing()
    {
        _thisBut.transform.localScale -= new Vector3(0.15f, 0.15f, 0.15f);
    }

    public void changeClicksCount(int howChange)
    {
        _howChange += howChange;
    }
}
