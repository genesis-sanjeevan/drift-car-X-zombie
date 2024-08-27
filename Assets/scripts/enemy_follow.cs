using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class enemy_follow : MonoBehaviour
{
    Transform car;
    [SerializeField] NavMeshAgent enemy;
    GameObject endGame;
    


    void Update()
    {
        if (car != null)
            enemy.SetDestination(car.position);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ring")
        {

            Destroy(gameObject);

        }   
    }

    public void set_endGame(GameObject endGame)
    {
        this.endGame = endGame;
    }
    public void Set_Car(Transform Trans_car)
    {
        car = Trans_car;
    }   
}
