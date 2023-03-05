using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesScript : MonoBehaviour
{
    public Button botonIniciar;
    public Button botonInstrucciones;
    public Button btnManolo;
    public Text txtMenu;

    // Start is called before the first frame update
    void Start()
    {
        botonIniciar.onClick.AddListener(() => { Application.LoadLevel("SampleScene"); });
        botonInstrucciones.onClick.AddListener(() =>
        {
            botonIniciar.gameObject.SetActive(false);
            botonInstrucciones.gameObject.SetActive(false);
            btnManolo.gameObject.SetActive(false);
            txtMenu.gameObject.SetActive(false);
            
        });
        btnManolo.onClick.AddListener(() => { Debug.Log("soy manolo"); });
    }

    // Update is called once per frame
    void Update()
    {
    }
}