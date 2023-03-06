using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    public GameManager gameManager;
    
    public ParticleSystem explosion;
    
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        explosion = GameObject.Find("Explosion").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        if (gameManager.vidasCaco <= 0 && gameManager.cacoExplotado == false)       
        {
            explosion.Play();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.gameOver)
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Gallina"))
        {
            gameManager.gameOver = true;
            gameManager.polloSound.Play();
            gameManager.ganador = "Caco";
            Destroy(gameObject);
            
        }
        else if (other.gameObject.CompareTag("Caco") && gameObject.CompareTag("Bala"))

        {
            gameManager.vidasCaco--;
            Destroy(gameObject);
            
            
        } else if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }

    }
}