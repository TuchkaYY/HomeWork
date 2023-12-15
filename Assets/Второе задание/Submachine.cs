using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Submachine : Weapon
{
    private const float _delayShoot = 0.2f;
    private const int _capasity = 3;

    [SerializeField, Range(0, 120)] private int _bulletAmount;

    private void OnValidate()
    {
        ValidateBulletAmount();
    }

    public override void Shoot()
    {
        if (_bulletAmount <= 0)
        {
            Debug.Log($"у {this.name} Патроны закончились");
            return;
        }

        StartCoroutine(Shooting());

        _bulletAmount -= _capasity;
    }

    private IEnumerator Shooting()
    {
        for (int i = 0; i < _capasity; i++)
        {
            BulletCreator.Create(BulletStartTransform.position, BulletStartTransform.rotation);
            yield return new WaitForSeconds(_delayShoot);
        }
    }

    private void ValidateBulletAmount()
    {
        string bulletAmountString = _bulletAmount.ToString();

        int count = 0;

        for (int i = 0; i < bulletAmountString.Length; i++)
        {
            count += int.Parse(bulletAmountString);
        }

        if (count % 3 != 0)
        {
            _bulletAmount = 30;
        }
    }
}
