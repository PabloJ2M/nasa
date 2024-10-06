using UnityEngine;

public class Rotate : MonoBehaviour
{
    private void FixedUpdate() => transform.Rotate(Vector3.up, 1);
}