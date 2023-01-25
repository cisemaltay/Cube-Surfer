using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject goal;
    public Vector3 road;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(this.transform.position,goal.transform.position+road,0.25f);
    }
}
