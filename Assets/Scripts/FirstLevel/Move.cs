using UnityEngine;

public class Move : MonoBehaviour {
	Rigidbody2D rb;
	public float moveSpeed = 30f;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() {
		Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
	    this.rb.velocity = moveDir * moveSpeed;	
	}
}
