using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CacoCarController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 direccion { get; set; } = Vector3.right;
    [Range(1, 10)]
    public int speed = 5;
    public float limite  = 4f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * (Time.deltaTime * speed));
        if (transform.position.x >= limite)
        {
            direccion = Vector3.left;
        }
        else if (transform.position.x <= -limite)
        {
            direccion = Vector3.right;
        }
    }

    
}