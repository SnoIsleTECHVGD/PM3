using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public GameObject bulletSprite;
    public float bulletSpeed = 10;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletSprite, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
    }
}
