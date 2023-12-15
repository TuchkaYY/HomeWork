using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStore : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons;

    public IEnumerable<Weapon> Weapons => weapons;
}
