using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public static GPS Instace { set; get; }

    public float latitude;
    public float longitude;
    public bool gps;
    public GameObject OutOfPlace;

    public float right  = 12.53999f;
    public float left   = 12.53505f;
    public float top    = 54.41244f;
    public float bottom = 54.41019f;

    private void Start()
    {
        Instace = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }

    private void Update()
    {
        if(gps = true)
        {
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;

            if(bottom < latitude && latitude < top && left < longitude && longitude < right)
            {
                OutOfPlace.SetActive(false);
            }
            else
            {
                OutOfPlace.SetActive(true);
            }
        }
    }

    private IEnumerator StartLocationService()
    {
        if(!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS not Enabled");
            gps = false;
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status ==LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if(maxWait<=0)
        {
            Debug.Log("Timed Out");
            gps = false;
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine Location");
            gps = false;
            yield break;
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        gps = true;

        yield break;

    }
}
