using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEscenario : MonoBehaviour
{
    public GameManager gameManager;

    private Vector3 startPos;

    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver == false)
        {
            transform.Translate(Vector3.back * (Time.deltaTime * 5));
            if (transform.position.z < startPos.z - repeatWidth)
            {
                        transform.position = startPos;
            }
        }
    }
}