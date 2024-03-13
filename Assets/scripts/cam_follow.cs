using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Transform cam_position;


    void Update()
    {
        if (targetTransform != null)
        {
            
            transform.position = cam_position.position;
            transform.LookAt(targetTransform);
        }
    }
}