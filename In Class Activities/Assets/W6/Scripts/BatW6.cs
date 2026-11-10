using UnityEditor.VersionControl;
using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] public Transform target;

    private void Start()
    {
    }

    private void Update()
    {
    }

    public void Chase(Transform target)
    {
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        transform.position += (Vector3)(direction * _speed * Time.deltaTime);
    }
}
