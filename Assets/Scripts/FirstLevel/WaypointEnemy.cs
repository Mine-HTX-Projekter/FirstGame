using UnityEngine;

public class WaypointEnemy : MonoBehaviour {
    public Transform[] waypoints;
    public float distanceToSwapWP = 0.25f;
    public float speed = 20f;
    
    private int nextWaypoint = 1;
    private Rigidbody2D rb;
    
    void Start() {
        this.rb = GetComponent<Rigidbody2D>();
        transform.position = this.waypoints[0].position;
    }

    void FixedUpdate() {
        Vector2 direction = this.waypoints[this.nextWaypoint].position - transform.position;
        if (direction.sqrMagnitude < this.distanceToSwapWP) {
            this.nextWaypoint = (this.nextWaypoint + 1) % this.waypoints.Length;
        }

        this.rb.velocity = direction.normalized * this.speed;
    }
}
