using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float desiredAngle = player.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = player.transform.position - (rotation * offset);
        transform.LookAt(player.transform);
    }
}
