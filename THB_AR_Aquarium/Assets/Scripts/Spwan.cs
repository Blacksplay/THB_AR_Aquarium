using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Spwan : MonoBehaviour
{
    public GameObject obj;

    //spawnt das Objekt f�r den Server
    void Start()
    {
        obj.GetComponent<NetworkObject>().Spawn(); 
    }


}
