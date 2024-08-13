using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_follow : MonoBehaviour
{
    Transform car;
    [SerializeField] NavMeshAgent enemy;


    void Update()
    {
        if (car != null)
            enemy.SetDestination(car.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(collision.collider.gameObject);
        }

    }

    public void Set_Car(Transform Trans_car)
    {
        car = Trans_car;
    }   
}
