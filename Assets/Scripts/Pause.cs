using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool paused = false;
    public GameObject PauseScreen;
    void Start()
    {
        PauseScreen.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&paused==false)
        {
            Time.timeScale = 0;
            paused = true;
            PauseScreen.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Time.timeScale = 1;
            paused = false;
            PauseScreen.SetActive(false);
        }
    }
    public void Continue()
    {
        Time.timeScale = 1;
        paused = false;
        PauseScreen.SetActive(false);
    }
    public void Back()
    {
        Time.timeScale = 1;
        paused = false;
        Untergrund.die = false;
        Inventar.item = 0;
        Punkte.points = 0;
        Spawner.mode = 0;
        Spawner.amount = 0;
        PauseScreen.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
