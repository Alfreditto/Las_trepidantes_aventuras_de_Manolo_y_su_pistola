using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun;
    public GameObject bullet;
    public float cooldown = 2f;
    public float nextFire;
    public GameManager gamema;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextFire && gamema.gameOver == false)
        {   
            nextFire = Time.time + cooldown;
            Instantiate(bullet,
                new Vector3(gun.transform.position.x, gun.transform.position.y + 1,
                    gun.transform.position.z),
                new Quaternion(gun.transform.rotation.x, gun.transform.rotation.y, gun.transform.rotation.z + 180f,
                    gun.transform.rotation.w));
        }
    }
}