using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesMenuScript : MonoBehaviour
{
    public Button botonIniciar;
    public Button btnManolo;

    // Start is called before the first frame update
    void Start()
    {
        botonIniciar.onClick.AddListener(() => { SceneManager.LoadScene(1); });
        btnManolo.onClick.AddListener(() => { SceneManager.LoadScene(2); });
    }

    // Update is called once per frame
    void Update()
    {
    }
}