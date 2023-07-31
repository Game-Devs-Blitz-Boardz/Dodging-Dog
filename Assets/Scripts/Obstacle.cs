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

        if (other.gameObject.tag == "Player") {
            Destroy(other.gameObject);
            GameManager.instance.GameOver();
        }

        if (other.gameObject.tag == "Ground") {
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
    }

}
