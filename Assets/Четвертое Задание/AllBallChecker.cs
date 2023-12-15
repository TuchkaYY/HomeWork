using UnityEngine;

public class AllBallChecker : WinChecker
{
    public AllBallChecker(int ballCount, BallType ballType) : base(ballCount, ballType) { }

    public override void TryWin()
    {
        if (BallCount <= 0)
        {
            Debug.Log("Все шарики лопнуты!");
        }
    }
}
