using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorHandler : MonoBehaviour
{
    public static Queue<double> qLat;
    public static Queue<double> qLon;
    public Text btn;
    public static int NUM_OF_GPS_READINGS = 10;
    public void Start()
    {
        qLat = new Queue<double>();
        qLon = new Queue<double>();
    }
    public void startCollecting()
    {
        btn.text = "START";
        SpinCity.isCollecting = NUM_OF_GPS_READINGS;
    }
}
