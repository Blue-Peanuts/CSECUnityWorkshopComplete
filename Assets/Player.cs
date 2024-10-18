using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 10f;
    public GameObject bulletPrefab;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
    
    void FixedUpdate()
    {
        Vector2 moveVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity += Vector2.right;
        }
        rb2d.velocity = moveVelocity.normalized * speed;
    }
}
