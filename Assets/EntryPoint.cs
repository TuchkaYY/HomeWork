using UnityEngine;
using System.Linq;

public sealed class EntryPoint : MonoBehaviour
{
    [SerializeField] private WeaponStore _weaponStore;
    [SerializeField] private ShopZone _shopZone;

    [SerializeField] private Player _player;
    [SerializeField] private Trader _trader;

    [SerializeField] private WinHandler _winWindow;

    [SerializeField] private BallCollection _ballCollection;

    private void Awake()
    {
        WeaponInventory weaponInventory = new WeaponInventory(_weaponStore.Weapons, _weaponStore.Weapons.Count());

        WinCheckerFabric WinCheckerFabric = new WinCheckerFabric();
        ShopFabric shopFabric = new ShopFabric();

        _player.Inizialize(weaponInventory);
        _shopZone.Initialize(_trader, shopFabric);

        WinChecker winChecker = WinCheckerFabric.Get(_winWindow.WinType, _ballCollection.GetCountBallsByWinType(_winWindow.WinType));
        _winWindow.SetWinCondition(winChecker, _ballCollection.GetConcreteBalls(winChecker.BallType));
    }
}
