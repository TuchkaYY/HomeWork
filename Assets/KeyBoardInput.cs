using UnityEngine;

public class KeyBoardInput
{
    private Transform _playerTransform;

    public KeyBoardInput(Transform transform)
    {
        _playerTransform = transform;
    }

    public void Move(float speed)
    {
        Vector3 vector = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        _playerTransform.Translate(vector);
    }

    public void Rotate(float sensetivity)
    {
        _playerTransform.Rotate(0, Input.GetAxis("Mouse X") * sensetivity, 0);
    }
}
