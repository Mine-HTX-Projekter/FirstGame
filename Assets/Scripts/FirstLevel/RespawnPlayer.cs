using UnityEngine;

public class RespawnPlayer : MonoBehaviour {
    private Vector2 spawnPos;
    private Rigidbody2D rb;

    private void Start() {
        this.spawnPos = transform.position;
        this.rb = GetComponent<Rigidbody2D>();
    }

    public void SetSpawnPoint(Vector2 newSpawn) {
        this.spawnPos = newSpawn;
    }

    public void Respawn() {
        this.rb.velocity = Vector2.zero;
        transform.position = this.spawnPos;
    }
}
