using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    private WinChecker _winChecker;

    [field: SerializeField] public WinType WinType { get; private set; }

    public void SetWinCondition(WinChecker winChecker, IEnumerable<Ball> balls)
    {
        _winChecker = winChecker;

        foreach (var ball in balls)
        {
            ball.OnChecked += _winChecker.RemoveBall;
        }
    }
}
