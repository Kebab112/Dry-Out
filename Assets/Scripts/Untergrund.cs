using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Untergrund : MonoBehaviour
{
    public Color[] colors;
    public Image image;
    public Text text;
    int color=0;
    public static bool die=false;
    void Start()
    {
        StartCoroutine(drying());
    }
    void Update()
    {
        if(color<colors.Length)
        {
            image.color = colors[color];
        }
        else
        {
            die = true;
        }
        text.text = "Drynesslevel " + (color+1) + "/" + (colors.Length+1);
    }
    public IEnumerator drying()
    {
        while(true){
            yield return new WaitForSeconds(Random.Range(1,3));
            color++;
        }
    }
    public void watering()
    {
        if(Inventar.item == 0)
        {
            color = 0;
        }
    }
}
