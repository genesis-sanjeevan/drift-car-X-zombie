using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class car_spawning : MonoBehaviour
{
    public GameObject[] car;
    public scoresave Scoresave;
    [SerializeField] Vector3 spawnPosition = new Vector3(10, 1, 3);
    GameObject player;
    public enemy_spawner Enemy_spawner;
    public CameraFollow CameraFollow;

    private void Start()
    {
       

        switch (Scoresave.getCar())
        {
            case Cars.Prometheus:
                player = Instantiate(car[0], spawnPosition, Quaternion.identity);
                CameraFollow.carTransform = player .transform;
                Enemy_spawner.Car = player.transform;
                break;

            case Cars.KoenigseggJeskoAbsolute:
                Instantiate(car[1], spawnPosition, Quaternion.identity);
                CameraFollow.carTransform = player.transform;
                Enemy_spawner.Car = player.transform;
                break;

            case Cars.LamborghiniSianFKP37:
                Instantiate(car[2], spawnPosition, Quaternion.identity);
                CameraFollow.carTransform = player.transform;
                Enemy_spawner.Car = player.transform;
                break;

            case Cars.TeslaTruck:
                Instantiate(car[3], spawnPosition, Quaternion.identity);
                CameraFollow.carTransform = player.transform;
                Enemy_spawner.Car = player.transform;
                break;

        }
    }
    
}
