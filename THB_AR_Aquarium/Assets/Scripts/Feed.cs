using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    [SerializeField]
    public ClickedObject hungryGuy;

    //enth�lt die Button-Funktion zum f�ttern
    public void FeedObject()
    {
        hungryGuy.Health += 10;
    }
}
