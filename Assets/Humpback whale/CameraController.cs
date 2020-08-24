using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSmoothingFactor = 1;
    public float lookUpMax = 60;
    public float lookUpMin = -60;

    private Quaternion camRoation;

    // Start is called before the first frame update
    void Start()
    {
        camRoation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        camRoation.x += Input.GetAxis("Mouse Y") * cameraSmoothingFactor*(-1);   // look up/down
        camRoation.y += Input.GetAxis("Mouse X") * cameraSmoothingFactor;   // look left/right

        camRoation.x = Mathf.Clamp(camRoation.x, lookUpMin, lookUpMax);
        transform.localRotation = Quaternion.Euler(camRoation.x, camRoation.y, camRoation.z);
    }
}
