using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cacoCar;
    public GameObject pollo;
    public float spawnRate = 3f;
    public float cooldown = 0f;
    public Vector3 cacoCarPosition;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(SpawnPollo());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnPollo()
    {
        while (gameManager.gameOver == false)
        {
            cacoCarPosition = cacoCar.transform.position;
            yield return new WaitForSeconds(spawnRate);
            GameObject badItem = pollo;
            Instantiate(badItem, new Vector3(cacoCarPosition.x, 0, cacoCarPosition.z),
                Quaternion.Euler(0f, cacoCar.transform.eulerAngles.y + 180f, 0f));
        }
    }
}