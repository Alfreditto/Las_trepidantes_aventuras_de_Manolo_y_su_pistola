using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfazMainView : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI txtEstado;
    public GameObject pistola;
    public float nextFire;
    public TextMeshProUGUI txtEstadoPistola;

    // Start is called before the first frame update
    void Start()
    {
        pistola = GameObject.Find("Gun");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        txtEstadoPistola = GameObject.Find("Estado").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        nextFire = pistola.GetComponent<ShootingScript>().nextFire;
        switch (gameManager.vidasCaco)
        {
            case 4:
                txtEstado.text = "Perfecto";
                txtEstado.color = Color.blue;
                break;
            case 3:
                txtEstado.text = "Bueno";
                txtEstado.color = Color.green;

                break;
            case 2:
                txtEstado.text = "Rasguñado";
                txtEstado.color = Color.yellow;
                break;
            case 1:
                txtEstado.text = "Dañado";
                txtEstado.color = Color.red;
                break;
            case 0:
                txtEstado.text = "Al desguace";
                txtEstado.color = Color.black;
                break;
        }

        if (Time.time >= nextFire)
        {
            txtEstadoPistola.text = "Dispara!";
            txtEstadoPistola.color = Color.green;
        }
        else
        {
            txtEstadoPistola.text = "Recargando";
            txtEstadoPistola.color = Color.yellow;
        }
    }
}