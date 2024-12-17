using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseText;
    public GameObject ESCText;
    public GameObject menuButton;
    public bool isGamePaused;
    // Start is called before the first frame update
    void Start()
    {
        isGamePaused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGamePaused == false && Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = true;
            Time.timeScale = 0;
        }
        else if(isGamePaused == true && Input.GetKeyDown(KeyCode.Escape))
        { 
            isGamePaused = false;
            Time.timeScale = 1;
        }
        if (isGamePaused == false)
        {
            pauseText.SetActive(false);
            ESCText.SetActive(false);
            menuButton.SetActive(false);
        }
        if (isGamePaused == true)
        {
            pauseText.SetActive(true);
            ESCText.SetActive(true);
            menuButton.SetActive(true);
        }
    }
}
