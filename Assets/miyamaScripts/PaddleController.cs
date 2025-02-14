using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(inputX * speed, 0);
    }
}
