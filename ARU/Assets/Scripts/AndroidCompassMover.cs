using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidCompassMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, -SpinCity.toRotate360, transform.eulerAngles.z);

    }
}
