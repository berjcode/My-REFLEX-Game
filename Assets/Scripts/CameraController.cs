using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject  playerCamera;
    Vector2 distance;

    private void Start()
    {
        distance = transform.position - playerCamera.transform.position;
    }
    private void Update()
    {
        transform.position=playerCamera.transform.position*distance;
    }
}
