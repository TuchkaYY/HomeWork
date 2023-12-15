using UnityEngine;

public class Trader : MonoBehaviour
{
    private IShop _shop;

    public void SetShop(IShop shop)
    {
        _shop = shop;
    }

    public void Trade()
    {
        _shop.Interact();
    }
}
