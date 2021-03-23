using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float coinPoints = 10f;
    [SerializeField] private float rotateSpeed = 120f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Game_Manager.totalCoinPoints += coinPoints;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }
}
