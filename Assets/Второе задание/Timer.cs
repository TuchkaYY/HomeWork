
public sealed class Timer
{
    private readonly float _maxCount;

    public float _currentCount;

    public bool IsReady { get; private set; }

    public Timer(float maxCount, bool isReady = false)
    {
        _maxCount = maxCount;
        IsReady = isReady;
    }

    public void Update(float deltaTime)
    {
        _currentCount += deltaTime;

        if (_currentCount >= _maxCount)
            IsReady = true;

        if (_currentCount == float.MaxValue)
            _currentCount = _maxCount;
    }

    public void Reset()
    {
        _currentCount = 0;
        IsReady = false;
    }
}
