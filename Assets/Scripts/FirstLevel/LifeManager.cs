using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
    public Text lifeScore;
    public int maxLives = 3;
    public int livesLost = 0;

    public void LoseLife() {
        this.livesLost++;
        if (this.livesLost == this.maxLives) {
            Destroy(this.gameObject);
            SceneManager.LoadScene("DeathScene");
        }

        this.lifeScore.text = (this.maxLives - this.livesLost).ToString();
    }

}
