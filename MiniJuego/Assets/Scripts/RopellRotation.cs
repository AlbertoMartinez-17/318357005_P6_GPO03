using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float rotationSpeed = 1000f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
