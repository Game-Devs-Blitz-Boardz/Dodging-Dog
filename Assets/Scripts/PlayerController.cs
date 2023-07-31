using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;
    SpriteRenderer sr;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate() {
        if (Input.GetMouseButton(0)) {

            if (Input.mousePosition.x < Screen.width / 2) {
                rb.velocity = Vector2.left * moveSpeed;
                sr.flipX = true;
            } else {
                rb.velocity = Vector2.right * moveSpeed;
                sr.flipX = false;
            }

        }
    }
}
