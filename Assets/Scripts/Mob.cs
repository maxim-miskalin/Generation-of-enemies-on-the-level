using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _minPositionY = -20f;

    private void Update()
    {
        transform.Translate(new(_speed * Time.deltaTime, 0, 0));

        if(transform.position.y < _minPositionY)
            Destroy(gameObject);
    }
}
