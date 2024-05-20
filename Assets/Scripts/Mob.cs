using Unity.VisualScripting;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _minPositionForDeathY = -20f;

    private GameObject _target;

    private void Update()
    {
        if (_target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        }

        if (transform.position.y < _minPositionForDeathY)
            Destroy(gameObject);
    }

    public void SetTarget(GameObject target)
    {
        _target = target;
    }
}
