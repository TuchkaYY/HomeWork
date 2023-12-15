using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFabric
{
    public IShop Get(int reputation)
    {
        if (reputation >= 3 && reputation < 6)
        {
            return new FruitShop();
        }

        if (reputation >= 6)
        {
            return new ArmorShop();
        }

        return new NoShop();
    }
}
