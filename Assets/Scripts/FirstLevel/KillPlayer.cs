using UnityEngine;

public class KillPlayer : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        DecreaseLife(other.collider);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        DecreaseLife(other);
    }

    private void DecreaseLife(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<RespawnPlayer>().Respawn();
            other.gameObject.GetComponent<LifeManager>().LoseLife();
        }
    }
}
