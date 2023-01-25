using System;
using UnityEditor.UIElements;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float rightAndLeftSpeed;

    private void Start()
    {
        
    }
    private void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * rightAndLeftSpeed * Time.deltaTime;
        
        transform.Translate(horizontalAxis,0,forwardSpeed*Time.deltaTime);
    }
}
