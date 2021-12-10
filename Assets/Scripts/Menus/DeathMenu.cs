using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public void PlayNowButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel");
    }

    public void QuitButton() {
        Application.Quit();
    }
}
