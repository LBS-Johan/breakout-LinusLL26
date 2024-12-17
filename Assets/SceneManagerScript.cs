using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public ScoreManager scoreManager;
    public void SwitchToMainGame()
    {
        SceneManager.LoadScene(2);
    }
    public void SwitchToOptions()
    {
        SceneManager.LoadScene(3);
    }
    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (scoreManager != null)
        {
            if (scoreManager.blockContainer.childCount == 0)
        {
            SceneManager.LoadScene(4);
        }
        }
        
    }
}
