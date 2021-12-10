using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    public int myScore = 0;
    
    void Start() {
        this.scoreText = GetComponent<Text>();
        this.UpdateScore(0);
    }

    public void UpdateScore(int value) {
        this.myScore += value;
        this.scoreText.text = this.myScore.ToString();
    }
}
