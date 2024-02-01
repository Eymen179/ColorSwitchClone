using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuManager : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
    public void ReturnMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
