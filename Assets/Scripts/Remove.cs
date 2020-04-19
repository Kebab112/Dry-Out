using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remove : MonoBehaviour
{
    public int points;
    public void remove()
    {
        if (points == 1 && Inventar.item == 1 && this.gameObject.name.StartsWith("UNK"))
        {
            Spawner.amount--;
            Punkte.points += points;
            Destroy(this.gameObject);
        }
        if (points == 5 && Inventar.item == 2 && this.gameObject.name.StartsWith("UNK"))
        {
            Spawner.amount--;
            Punkte.points += points;
            Destroy(this.gameObject);
        }
    }
}
