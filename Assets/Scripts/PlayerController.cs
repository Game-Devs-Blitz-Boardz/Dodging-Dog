using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
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
            } else {
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
    }
}
