using UnityEngine;

public class GreenBallChecker : WinChecker
{
    public GreenBallChecker(int ballCount, BallType ballType) : base(ballCount, ballType) { }

    public override void TryWin()
    {
        if (BallCount <= 0)
        {
            Debug.Log("Зеленые шарики Лопнуты!");
        }
    }
}
