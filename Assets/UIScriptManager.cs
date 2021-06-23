using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptManager : MonoBehaviour
{
    public Text lat, lon;

    // Update is called once per frame
    void Update()
    {
        lat.text ="Lat: "+ GpsLocation.latitude.ToString();
        lon.text = "Lon: "+ GpsLocation.longitude.ToString();

    }
}
