using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Enemy>() != null)
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage();
            Destroy(gameObject);
        }
    }
}
