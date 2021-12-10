using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinPickup : MonoBehaviour {
    private int value = 1;
    public CircleCollider2D[] coins;

    private void OnTriggerEnter2D(Collider2D other) {
        CircleCollider2D otherCollider = other.GetComponent<CircleCollider2D>();
        
        if (otherCollider == null) return;
        
        int toDelIndex = Array.FindIndex(this.coins, v => v == otherCollider);
        this.coins[toDelIndex] = null;
        
        Destroy(other.gameObject);
        FindObjectOfType<Score>().UpdateScore(this.value);
        
        bool wasLastCoin = Array.FindAll(this.coins, v => v != null).Length == 0;
        if (wasLastCoin) {
            SceneManager.LoadScene("WinScene");
        }
    }
}
