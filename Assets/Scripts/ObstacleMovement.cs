using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private float maxRightPosition = 5.5f;
    [SerializeField] private float maxLeftPosition = -5.5f;
    [SerializeField] private float speed = 5f;


    bool movingRight;
    bool movingLeft;

    // Start is called before the first frame update
    void Start()
    {
        movingRight = true;
        movingLeft = false;
    }

    // Update is called once per frame
    void Update()
    {  
        if (movingRight)
        {
            moveRight();
            if (transform.position.x >= maxRightPosition)
            {

                movingRight = false;
                movingLeft = true;
            }
        }
        else if (movingLeft)
        {
            moveLeft();
            if (transform.position.x <= maxLeftPosition)
            {
                movingRight = true;
                movingLeft = false;
            }
        }
    }

    void moveRight()
    {
        direction = new Vector3(maxRightPosition, transform.position.y, transform.position.z) - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    void moveLeft()
    {
        direction = new Vector3(maxLeftPosition, transform.position.y, transform.position.z) - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
