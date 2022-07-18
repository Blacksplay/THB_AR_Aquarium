using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPS : MonoBehaviour
{
    public Text coordinates;

    private void Update()
    {
        coordinates.text = "LAT: " + GPS.Instace.latitude.ToString() + " LONG: " + GPS.Instace.longitude.ToString();
    }
}
