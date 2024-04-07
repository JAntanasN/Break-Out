using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{

    public float speed = 10;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //move up at the start
        rb.velocity = Vector2.up * speed;
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;

        if(rb.velocity.normalized == Vector2.zero)
        {
            rb.velocity = Vector2.up + Vector2.right * Random.Range(-0.5f, 0.6f) * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("End"))
        {
            GameManager.lives--;

            var player = GameObject.FindWithTag("Player");
            transform.position = player.transform.position + Vector3.up;
            rb.velocity = Vector2.up * speed;
        }
    }
}
