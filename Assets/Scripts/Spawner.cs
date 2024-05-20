using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mob _prefabMob;
    [SerializeField] private List<SpawnPoint> _spawnPoints = new();
    [SerializeField] private float _repeadRate = 2f;

    private bool _isWork = true;

    private void Start()
    {
        StartCoroutine(CreateMob());
    }

    private IEnumerator CreateMob()
    {
        while (_isWork)
        {
            Vector3 direction;
            Mob mob = Instantiate(_prefabMob);
            mob.transform.position = GetSpawnPoint(out direction);
            mob.SetDirection(direction);

            yield return new WaitForSeconds(_repeadRate);
        }
    }

    private Vector3 GetSpawnPoint(out Vector3 direction)
    {
        int numberSpawnPoint = Random.Range(0, _spawnPoints.Count);
        direction = _spawnPoints[numberSpawnPoint].Direction;
        return _spawnPoints[numberSpawnPoint].transform.position;
    }
}
