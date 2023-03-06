using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public int vidasCaco = 4;
    public ParticleSystem explosion;
    public bool cacoExplotado = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        vidasCaco = 4;
        cacoExplotado = false;
        explosion = GameObject.Find("Explosion").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidasCaco > 0) return;
        gameOver = true;
    }
}
