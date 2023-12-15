using UnityEngine;

public class RedBallChecker : WinChecker
{
    public RedBallChecker(int ballCount, BallType ballType) : base(ballCount, ballType) { }

    public override void TryWin()
    {
        if (BallCount <= 0)
            Debug.Log("Все Красные шарики лопнуты!");
    }
}
