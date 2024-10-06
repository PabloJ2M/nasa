using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate() => transform.Rotate(Vector3.up, _speed * Time.fixedDeltaTime);
}