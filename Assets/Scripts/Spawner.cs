using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mob _prefabMob;
    [SerializeField] private List<SpawnPoint> _spawnPoints = new();
    [SerializeField] private float _repeadRate = 2f;

    WaitForSeconds _wait;
    private bool _isWork = true;

    private void Start()
    {
        _wait = new(_repeadRate);

        StartCoroutine(CreateMob());
    }

    private IEnumerator CreateMob()
    {
        while (_isWork)
        {
            Vector3 direction;
            Mob mob = Instantiate(_prefabMob);
            mob.transform.position = GetSpawn(out direction);
            mob.SetDirection(direction);

            yield return _wait;
        }
    }

    private Vector3 GetSpawn(out Vector3 direction)
    {
        int numberSpawnPoint = Random.Range(0, _spawnPoints.Count);
        direction = _spawnPoints[numberSpawnPoint].Direction;
        return _spawnPoints[numberSpawnPoint].transform.position;
    }
}
