using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    public GameObject Screen;

    //schlie�t ge�ffnete Infoscreens
    public void close()
    {
        Screen.SetActive(false);
    }

}
