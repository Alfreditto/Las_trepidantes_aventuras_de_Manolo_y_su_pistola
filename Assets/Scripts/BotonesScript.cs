using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesScript : MonoBehaviour
{
    public Button botonIniciar;
    public Button btnManolo;

    // Start is called before the first frame update
    void Start()
    {
        botonIniciar.onClick.AddListener(() => { SceneManager.LoadScene("MainScene"); });
        btnManolo.onClick.AddListener(() => { Debug.Log("soy manolo"); });
    }

    // Update is called once per frame
    void Update()
    {
    }
}