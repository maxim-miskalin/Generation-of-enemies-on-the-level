using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Mob _prefab;
    [SerializeField] private GameObject _target;

    public Mob GetMob => _prefab;
    public GameObject GetTarget => _target;
}