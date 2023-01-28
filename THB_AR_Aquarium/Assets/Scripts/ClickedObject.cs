using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ClickedObject : NetworkBehaviour
{

    //Parameter der Fische
    [SerializeField]
    public string ObjName;

    public double Health;

    public int ID;

    public bool hungry = true;

    public double changeovertime = 1;


    public Material Farbe;

    public Color color;

    void Update()
    {
        //Health ist immer ein Wert zwischen 1 und 100
        if(Health<0)
        {
            Health = 0;
        }
        if (Health > 100)
        {
            Health = 100;
        }

        //aktiviert den Hunger
        if (hungry)
        {
            hunger();
        }

        //setzt die Farbe des Herz-Sprites ja nach Hungerlevel
        if (Health < 25)
        {
            Farbe.color = Color.red;
        }
        if (Health < 75 && Health > 25)
        {
            Farbe.color = Color.yellow;
        }
        if (Health > 75)
        {
            Farbe.color = color;
        }

    }

    // Verfall des Hungers
    private void hunger()
    {

        Health -= changeovertime * Time.deltaTime;
    }
}
