using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
