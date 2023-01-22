using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(_direction * _speed);
    }
}