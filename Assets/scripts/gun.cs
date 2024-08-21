using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100;
    public float Max_Timer;
    public AudioSource shooting_audio;

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
            
            //shooting_audio.Play();
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            _Time = 0;
        }
    }
}
