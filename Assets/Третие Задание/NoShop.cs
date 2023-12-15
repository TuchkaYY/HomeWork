using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoShop : IShop
{
    public void Interact()
    {
        Debug.Log("магазин для вас не доступен!");
    }
}
