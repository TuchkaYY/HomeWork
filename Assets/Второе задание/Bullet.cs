using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField, Range(0, 70)] private float _speed = 30;
    [SerializeField, Range(0, 10)] private float _timeLife = 5;

    private Timer _timer;

    public void Awake()
    {
        _timer = new Timer(_timeLife);
    }

    private void Update()
    {
        _timer.Update(Time.deltaTime);

        transform.Translate(transform.InverseTransformDirection(transform.forward * Time.deltaTime * _speed));

        if (_timer.IsReady)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Ball>(out Ball ball))
        {
            ball.Burst();
            Destroy(gameObject);
        }
    }

    public void Inizialize(Vector3 startPosition, Quaternion rotation)
    {
        transform.position = startPosition;
        transform.rotation = rotation;
    }
}
