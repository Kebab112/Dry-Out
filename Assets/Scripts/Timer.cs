using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text Anzeige;
    public Image image;
    public Sprite[] sprites;
    public GameObject Endscreen;
    int sprite;
    int time=0;
    void Start()
    {
        Untergrund.die = false;
        StartCoroutine(timer());
    }
    private void Update()
    {
        image.sprite = sprites[sprite];
    }
    public IEnumerator timer()
    {
        while (!Untergrund.die) {
            yield return new WaitForSecondsRealtime(1);
            time++;
            Anzeige.text = "Timer: " + time ;
            if(time%60==0 && time<=180)
            {
                sprite ++;
                if (Spawner.mode <= 3)
                {
                    Spawner.mode++;
                }
            }
        }
        Endscreen.SetActive(true);

    }
    public void TryAgain()
    {
        Untergrund.die = false;
        Inventar.item = 0;
        Punkte.points = 0;
        Spawner.mode = 0;
        Spawner.amount = 0;
        Endscreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Back()
    {
        Time.timeScale = 1;
        Untergrund.die = false;
        Inventar.item = 0;
        Punkte.points = 0;
        Spawner.mode = 0;
        Spawner.amount = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
