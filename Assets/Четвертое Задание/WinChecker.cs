
public abstract class WinChecker
{
    public BallType BallType { get; private set; }
    protected int BallCount { get; private set; }

    public WinChecker(int ballCount, BallType ballType)
    {
        BallCount = ballCount;
        BallType = ballType;
    }

    public void RemoveBall()
    {
        BallCount -= 1;

        TryWin();
    }

    public abstract void TryWin();
}
