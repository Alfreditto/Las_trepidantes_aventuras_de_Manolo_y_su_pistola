using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarController : MonoBehaviour
{
    private float speed = 5f;
    private Animator animator;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
                    animator.SetBool("TurningLeft", true);
                    transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.World);
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (transform.position.x < 4f)
                {
                    animator.SetBool("TurningRight", true);
                    transform.Translate(Vector3.right * (Time.deltaTime * speed), Space.World);
                }
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetBool("TurningLeft", false);
            } else if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetBool("TurningRight", false);
            }
    
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Terminar el juego
    }
}