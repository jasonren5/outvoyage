using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCameraController : MonoBehaviour
{
    Camera mainCamera;
    Vector3 startingPosition;
    float interval;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        startingPosition = this.transform.position;
        interval = 2000f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + mainCamera.transform.position / interval;
        transform.rotation = mainCamera.transform.rotation;
    }
}