using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate() {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ground") {
            Destroy(gameObject);
        }
    }

}
