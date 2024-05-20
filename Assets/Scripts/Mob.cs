using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _minPositionForDeathY = -20f;

    private Vector3 _direction;

    private void Update()
    {
        if (_direction != null)
            transform.Translate(_direction * _speed * Time.deltaTime);

        if (transform.position.y < _minPositionForDeathY)
            Destroy(gameObject);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
