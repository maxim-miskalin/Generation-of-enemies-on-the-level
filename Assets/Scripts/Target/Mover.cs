using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Mover : MonoBehaviour
{
    [SerializeField] private GameObject[] _destinations = new GameObject[2];
    [SerializeField] private float _speed = 10f;

    private bool _isPassed = true;

    private void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void Update()
    {
        if (_isPassed)
        {
            transform.position = Vector3.MoveTowards(transform.position, _destinations[0].transform.position, _speed * Time.deltaTime);

            if (transform.position == _destinations[0].transform.position)
                _isPassed = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _destinations[1].transform.position, _speed * Time.deltaTime);

            if (transform.position == _destinations[1].transform.position)
                _isPassed = true;
        }
    }
}
