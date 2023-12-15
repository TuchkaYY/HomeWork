using UnityEngine;

public sealed class Pistol : Weapon
{
    private const int _capasity = 1;

    [SerializeField, Range(0,100)] private int _bulletAmount;

    public override void Shoot()
    {
        if (_bulletAmount <= 0)
        {
            Debug.Log($"у {this.name} Патроны закончились");
            return;
        }

        BulletCreator.Create(BulletStartTransform.position, BulletStartTransform.rotation);

        _bulletAmount -= _capasity;
    }
}
