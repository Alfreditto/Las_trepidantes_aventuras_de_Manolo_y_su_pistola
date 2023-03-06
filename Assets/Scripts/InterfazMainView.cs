using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfazMainView : MonoBehaviour
{
    public GameManager gameManager;

    public TextMeshProUGUI txtEstado;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}