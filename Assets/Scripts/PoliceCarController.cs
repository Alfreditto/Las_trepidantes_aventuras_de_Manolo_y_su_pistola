using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarController : MonoBehaviour
{
    private float speed = 5f;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (transform.position.x > -4f)
                {
                    transform.Translate(Vector3.left * (Time.deltaTime * speed));
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (transform.position.x < 4f)
                {
                    transform.Translate(Vector3.right * (Time.deltaTime * speed));
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Terminar el juego
    }
}