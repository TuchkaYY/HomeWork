using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class WeaponInventory
{
    private Weapon[] _weapons;

    private int _previousIndex;
    private int _currentIndex;

    public WeaponInventory(IEnumerable<Weapon> weapons, int size)
    {
        int index = 0;

        _weapons = new Weapon[size];

        foreach (var item in weapons)
        {
            _weapons[index] = item;
            index++;
        }
    }

    public void Equip(string keyCode)
    {
        int index = 0;
        int.TryParse(keyCode, out index);

        if (index > _weapons.Length || index == 0)
            return;

        _previousIndex = _currentIndex;
        _currentIndex = index - 1;

        _weapons[_previousIndex].Hide();
        _weapons[_currentIndex].Show();
    }
}
