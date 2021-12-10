using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour {
    public void PlayNowButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel");
    }

    public void QuitButton() {
        Application.Quit();
    }
}
