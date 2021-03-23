using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 60f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
