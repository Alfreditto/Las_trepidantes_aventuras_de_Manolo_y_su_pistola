using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -7f)
            {
                transform.Translate(Vector3.left * (Time.deltaTime * speed));
            }
        } else if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 7f)
            {
                transform.Translate(Vector3.right * (Time.deltaTime * speed));
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Terminar el juego
    }
}
