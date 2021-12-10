using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayNowButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel");
    }

    public void QuitButton() {
        Application.Quit();
    }
}