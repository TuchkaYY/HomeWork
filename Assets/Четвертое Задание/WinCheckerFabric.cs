using UnityEngine;

public sealed class WinCheckerFabric
{
    public WinChecker Get(WinType winType, int BallCount)
    {
        switch (winType)
        {
            case WinType.RedBalls:
                return new RedBallChecker(BallCount, BallType.Red);

            case WinType.GreenBalls:
                return new GreenBallChecker(BallCount, BallType.Green);

            case WinType.WhiteBalls:
                return new WhiteBallChecker(BallCount, BallType.White);

            default:
                return new AllBallChecker(BallCount, BallType.None);
        }
    }
}
