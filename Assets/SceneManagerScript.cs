using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void SwitchToMainGame()
    {
        SceneManager.LoadScene(1);
    }
    public void SwitchToOptions()
    {
        SceneManager.LoadScene(2);
    }
}