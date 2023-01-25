using System;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private GameObject surfParent;
    [SerializeField] private GameObject cubePrefab;
    
    private int _cubeNumber;

    public void AddCube()
    {
        Debug.Log("Added Cube");
        transform.position += Vector3.up;
        var cube = Instantiate(cubePrefab, surfParent.transform);
        cube.transform.position = transform.position + Vector3.down * _cubeNumber;
        _cubeNumber += 1;
    }
}
