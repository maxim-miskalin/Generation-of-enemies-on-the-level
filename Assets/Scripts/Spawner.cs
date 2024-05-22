using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints = new();
    [SerializeField] private float _repeadRate = 2f;

    private WaitForSeconds _wait;
    private bool _isWork = true;
    private SpawnPoint _currentSpawnPoint;

    private void Start()
    {
        _wait = new(_repeadRate);

        StartCoroutine(CreateMob());
    }

    private IEnumerator CreateMob()
    {
        while (_isWork)
        {
            SelectSpawnPoint();

            GameObject target = _currentSpawnPoint.GetTarget;
            Mob mob = Instantiate(_currentSpawnPoint.GetMob);
            mob.transform.position = _currentSpawnPoint.transform.position;
            mob.SetTarget(target);

            yield return _wait;
        }
    }

    private void SelectSpawnPoint()
    {
        int numberSpawnPoint = Random.Range(0, _spawnPoints.Count);
        _currentSpawnPoint = _spawnPoints[numberSpawnPoint];
    }
}
