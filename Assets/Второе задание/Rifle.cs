
public sealed class Rifle : Weapon
{
    public override void Shoot()
    {
        BulletCreator.Create(BulletStartTransform.position, BulletStartTransform.rotation);
    }
}
