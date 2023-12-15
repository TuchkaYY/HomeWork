using UnityEngine;

public class WhiteBallChecker : WinChecker
{
    public WhiteBallChecker(int ballCount, BallType ballType) : base(ballCount, ballType) { }

    public override void TryWin()
    {
        if(BallCount <= 0)
        {
            Debug.Log("Белые шарики Лопнуты!");
        }
    }
}
