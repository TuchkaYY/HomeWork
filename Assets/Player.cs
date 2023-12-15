using UnityEngine;

public sealed class Player : MonoBehaviour
{
    [SerializeField, Range(0, 50)] private float _speed;
    [SerializeField, Range(0, 100)] private float _sensetivity;

    private WeaponInventory _weaponInventory;
    private KeyBoardInput _keyBoardInput;

    [field: SerializeField] public int Reputation { get; private set; }

    private void Update()
    {
        _weaponInventory.Equip(Input.inputString);

        _keyBoardInput.Move(_speed);
        _keyBoardInput.Rotate(_sensetivity);
    }

    public void Inizialize(WeaponInventory weaponInventory)
    {
        _weaponInventory = weaponInventory;
        _keyBoardInput = new KeyBoardInput(transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Ball>(out Ball ball))
        {
            ball.Burst();
        }
    }
}
