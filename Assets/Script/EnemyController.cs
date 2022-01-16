using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /**
     * * Must check: Send Collision Messages in Particle Collision module
    */
    private void OnParticleCollision(GameObject other) {
        if (other.layer == 9){//Layer skill
            print("OnParticleCollision: Collision skill effect");
            Rigidbody2D rgbd = other.gameObject.GetComponent<Rigidbody2D>();
            rgbd.AddForce(Vector2.down);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 9){//Layer skill
            print("OnTriggerEnter2D: Collision skill effect");
            // Rigidbody2D rgbd = other.gameObject.GetComponent<Rigidbody2D>();
            Rigidbody2D rgbd = gameObject.GetComponent<Rigidbody2D>();
            rgbd.AddForce(Vector2.down*200);
            // rgbd.velocity = new Vector2(0, 2);
        }
    }

}
