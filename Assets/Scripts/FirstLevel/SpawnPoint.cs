using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        if (!other.CompareTag("Player")) return;
        other.gameObject.GetComponent<RespawnPlayer>().SetSpawnPoint(transform.position);
        Destroy(this.gameObject);
    }
}
