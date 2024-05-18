using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;

    private void Update()
    {
        transform.position = cameraPos.position;
    }
}
