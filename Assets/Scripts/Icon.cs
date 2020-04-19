using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icon : MonoBehaviour
{
    public Texture2D[] images;

    void Update()
    {
        Cursor.SetCursor(images[Inventar.item],Vector2.zero,CursorMode.ForceSoftware);
    }
}
