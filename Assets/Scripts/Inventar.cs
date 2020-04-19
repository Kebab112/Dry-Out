using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
    public static int item=0;
    public Image[] images;
    public Sprite sprite1;
    public Sprite sprite2;

    public void Update()
    {
        float var = Input.GetAxisRaw("Mouse ScrollWheel");
        if (var > 0)
        {
            item++;
            if (item > 2)
            {
                item = 0;
            }
            for (int i = 0; i < images.Length; i++)
            {
                images[i].sprite = sprite1;
            }
            images[item].sprite = sprite2;
        }
        if (var < 0)
        {
            item--;
            if (item < 0)
            {
                item = 2;
            }
            for (int i = 0; i < images.Length; i++)
            {
                images[i].sprite = sprite1;
            }
            images[item].sprite = sprite2;
        }
    }
    public void Onclick(int a)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = sprite1;
        }
        item = a;
        images[item].sprite = sprite2;
    }
}
