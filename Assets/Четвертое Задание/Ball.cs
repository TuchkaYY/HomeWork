using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Action OnChecked;

    [field: SerializeField] public BallType BallType { get; private set; }

    public virtual void Burst()
    {
        OnChecked?.Invoke();
        gameObject.SetActive(false);
        OnChecked = null;
    }
}
