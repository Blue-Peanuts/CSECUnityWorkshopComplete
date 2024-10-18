using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    public float spinSpeed = 100f;
    public int health = 3;
    public GameObject hurtParticlesPrefab;
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.down * speed;
    }

    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, 1) * Time.deltaTime * spinSpeed;
    }

    public void TakeDamage()
    {
        health--;
        Instantiate(hurtParticlesPrefab, transform.position, Quaternion.identity);
        GameFeedback.instance.EnemyHit();
        if (health <= 0)
        {
            Destroy(gameObject);
            for (int i = 0; i < 5; i++)
            {
                Instantiate(hurtParticlesPrefab, transform.position, Quaternion.identity);
                GameFeedback.instance.EnemyKilled();
            }
        }
    }
}
