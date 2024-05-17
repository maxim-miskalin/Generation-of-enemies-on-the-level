using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private Mob _prefabMob;
    [SerializeField] private float _turnY = 0f;
    [SerializeField] private float _repeadRate = 2f;

    private float _delay;
    private float _maxRotationEuler = 360f;

    private float _minPositionX;
    private float _maxPositionX;
    private float _minPositionZ;
    private float _maxPositionZ;

    private void Awake()
    {
        _minPositionX = GetComponent<Collider>().bounds.max.x;
        _maxPositionX = GetComponent<Collider>().bounds.max.x;
        _minPositionZ = GetComponent<Collider>().bounds.min.z;
        _maxPositionZ = GetComponent<Collider>().bounds.max.z;

        _delay = Random.Range(0, _delay);
        _turnY = Random.Range(0, _maxRotationEuler);
    }

    private void Start()
    {
       InvokeRepeating(nameof(CreateMob), _delay, _repeadRate);
    }

    private void CreateMob()
    {
        Vector3 position = new(Random.Range(_minPositionX, _maxPositionX), 1, Random.Range(_minPositionZ, _maxPositionZ));

        Instantiate(_prefabMob, position, Quaternion.Euler(0, _turnY, 0));
    }
}
