using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float Max_Timer;

    public float _Time;

    void Update()
    {
        Gun_code(); 

    }

    public void Gun_code()
    {
        _Time += Time.deltaTime;

        if (_Time >= Max_Timer)
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            _Time = 0;
        }
    }
}
