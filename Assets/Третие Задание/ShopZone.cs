using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopZone : MonoBehaviour
{
    private Trader _trader;
    private ShopFabric _choiceShop;

    public void Initialize(Trader trader, ShopFabric shopFabric)
    {
        _trader = trader;
        _choiceShop = shopFabric;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            IShop shop = _choiceShop.Get(player.Reputation);

            _trader.SetShop(shop);
            _trader.Trade();
        }
    }
}
