using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punkte : MonoBehaviour
{
    public static int points=0;
    public Text text;
    void Update()
    {
        text.text = "Points: " + points;
    }
}
