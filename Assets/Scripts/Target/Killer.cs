using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Renderer))]
public class Killer : MonoBehaviour
{
    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
