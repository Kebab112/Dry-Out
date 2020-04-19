using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] Unkraut;
    public GameObject can;
    public static int mode;
    public static int amount = 0;
    void Start()
    {
        StartCoroutine(spawn());
    }
    public IEnumerator spawn()
    {
        while (!Untergrund.die)
        {
            if (mode >= 2)
            {
                amount++;
                GameObject go= Instantiate(Unkraut[Random.Range(0,Unkraut.Length)], new Vector2(Random.Range(0,Screen.width), Random.Range(0, Screen.height-(int)(Screen.height*0.2))),Quaternion.identity);
                go.transform.parent = can.transform;
            }
            else
            {
                amount++;
                GameObject go = Instantiate(Unkraut[0], new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height - (int)(Screen.height * 0.2))), Quaternion.identity);
                go.transform.parent = can.transform;
            }
            if(amount>5)
            {
                Untergrund.die = true;
            }
            switch(mode)
            {
                case 0:yield return new WaitForSeconds(Random.Range(4 ,8));break;
                case 1:yield return new WaitForSeconds(Random.Range(4, 5)); break;
                case 2:yield return new WaitForSeconds(Random.Range(2, 5)); break;
                case 3:yield return new WaitForSeconds(Random.Range(1, 3)); break;
            }
        }
    }
}
