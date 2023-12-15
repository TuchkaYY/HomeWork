using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected Timer Timer { get; private set; }

    [SerializeField, Range(0.5f, 3)] private float _rollBackTime = 1;

    [field: SerializeField] protected Transform BulletStartTransform { get; private set; }
    [field: SerializeField] protected BulletCreator BulletCreator { get; private set; }

    private void Awake()
    {
        Timer = new Timer(_rollBackTime, true);
    }

    private void Update()
    {
        Timer.Update(Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            if (Timer.IsReady)
            {
                Shoot();
                Timer.Reset();
            }
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public abstract void Shoot();
}
