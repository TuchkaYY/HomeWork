using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallCollection : MonoBehaviour
{
    private List<Ball> _balls = new List<Ball>();

    public void OnValidate()
    {
        Ball[] balls = FindObjectsOfType<Ball>();

        _balls.Clear();

        for (int i = 0; i < balls.Length; i++)
        {
            _balls.Add(balls[i]);
        }
    }

    public IEnumerable<Ball> GetConcreteBalls(BallType ballType)
    {
        if (ballType == BallType.None)
            return _balls;

        var balls = _balls.Where(ball => ball.BallType == ballType);
        return balls;
    }

    public int GetCountBallsByWinType(WinType winType)
    {
        switch (winType)
        {
            case WinType.GreenBalls:
                return _balls.Where(ball => ball.BallType == BallType.Green).Count();

            case WinType.RedBalls:
                return _balls.Where(ball => ball.BallType == BallType.Red).Count();

            case WinType.WhiteBalls:
                return _balls.Where(ball => ball.BallType == BallType.White).Count();

            default:
                return _balls.Count;
        }
    }
}
