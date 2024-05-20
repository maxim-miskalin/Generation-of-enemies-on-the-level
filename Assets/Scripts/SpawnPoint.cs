using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _maxRandom = 2f;

    public Vector3 Direction => _direction;

    private void Awake()
    {
        _direction = new(Random.Range(0, _maxRandom), 0, Random.Range(0, _maxRandom));
    }
}
