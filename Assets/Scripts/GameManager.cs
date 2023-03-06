using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public int vidasCaco = 4;
    public ParticleSystem explosion;
    public bool cacoExplotado = false;
    public AudioSource explosionSound;
    public AudioSource polloSound;
    public string ganador;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        vidasCaco = 4;
        cacoExplotado = false;
        polloSound = GameObject.Find("Player").GetComponent<AudioSource>();
        explosionSound = GameObject.Find("caco_car").GetComponent<AudioSource>();
        explosion = GameObject.Find("Explosion").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidasCaco <= 0 && cacoExplotado == false && gameOver == false)
        {
            explosionSound.Play();
            explosion.Play();
            cacoExplotado = true;
            gameOver = true;
            ganador = "Policia";
        }
    }

    public void Reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}