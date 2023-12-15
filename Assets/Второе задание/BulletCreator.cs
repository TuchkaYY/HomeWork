using UnityEngine;

[CreateAssetMenu(fileName = "BulletCreator", menuName = "Bullet/BulletCreator")]
public sealed class BulletCreator : ScriptableObject
{
    [SerializeField] private Bullet _bullet;

    public void Create(Vector3 position, Quaternion rotation)
    {
        Bullet newBullet = _bullet;
        newBullet.Inizialize(position, rotation);

        Instantiate(newBullet);
    }
}
