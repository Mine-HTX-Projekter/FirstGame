using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public bool isPaused = false;
    public GameObject[] pauseComponents;

    private void Start() {
        foreach (GameObject o in this.pauseComponents) {
            o.SetActive(this.isPaused);
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) TogglePause();
    }

    public void ResumeGame() {
        TogglePause();
    }

    public void RestartGame() {
        SceneManager.LoadScene("FirstLevel");
        Time.timeScale = 1f;
    }

    public void QuitGame() {
        Application.Quit();
    }

    private void TogglePause() {
        Time.timeScale = Time.timeScale == 0f ? 1f : 0f;

        foreach (GameObject o in this.pauseComponents) {
            o.SetActive(!this.isPaused);
        }

        this.isPaused = !this.isPaused;
    }
}
