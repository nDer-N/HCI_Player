using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCont : MonoBehaviour
{
    public float velocity = 8f;
    public float Jump = 7f;

    private Rigidbody2D rb;
    private bool floor = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector3(movement * velocity, rb.linearVelocity.y, 0);

        if (floor && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Jump);
            floor = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            floor = true;
        }
    }
}
