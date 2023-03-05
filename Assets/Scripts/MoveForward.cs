using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Gallina"))
        {
            gameManager.gameOver = true;
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