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
    private int speed = 5;
    private float limite  = 4f;
    public GameManager gameManager;
    private Animator animator;

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
            transform.Translate(direccion * (Time.deltaTime * speed), Space.World);
            if (transform.position.x >= limite)
            {
                animator.SetBool("TurningRight", false);
                animator.SetBool("TurningLeft", true);
                direccion = Vector3.left;
            }
            else if (transform.position.x <= -limite)
            { 
                animator.SetBool("TurningLeft", false);
                animator.SetBool("TurningRight", true);
                direccion = Vector3.right;
            }
        }
    }

    
}