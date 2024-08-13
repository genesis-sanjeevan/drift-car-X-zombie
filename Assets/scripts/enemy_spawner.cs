using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_spawner : MonoBehaviour
{ 
    private float _Time;
    [SerializeField] Transform Car;
    [SerializeField] GameObject enemy;
    [SerializeField] float Max_Timer;

    GameObject enemy_Reference;
    private void Update()
    {
        _Time += Time.deltaTime;

        if (_Time >= Max_Timer)
        {
            EnemySpawner();
            _Time = 0;
        }
    }

    public void EnemySpawner()

    {


        int spawnPointX = Random.Range(-10, 10);
        int spawnPointY = Random.Range(2,2);
        int spawnPointZ = Random.Range(-10, 10);

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        enemy_Reference = Instantiate(enemy, spawnPosition, Quaternion.identity);

        enemy_Reference.GetComponent<enemy_follow>().Set_Car(Car);

    }
  

}
