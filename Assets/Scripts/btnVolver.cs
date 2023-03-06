using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class btnVolver : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonVolver;
    void Start()
    {
        buttonVolver.onClick.AddListener(() => { UnityEngine.SceneManagement.SceneManager.LoadScene(0); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
