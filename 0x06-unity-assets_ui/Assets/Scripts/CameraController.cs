using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 2.5f, -6.25f);
    void LateUpdate()
    {
        Rotate();
        transform.position = Vector3.Lerp(transform.position, (player.transform.position + offset), .25f);
        transform.LookAt(player.transform.position);
    }

    void Rotate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 4f, Vector3.up) * offset;
    }
}