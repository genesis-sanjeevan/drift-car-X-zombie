using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullets : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject coins;
    private void Start()
    {
        Destroy(gameObject,2f);
        
    }
    

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "enemy")
        {
            
            Destroy(collision.gameObject);

            Destroy(gameObject);

            
            Vector3 enemy_location = new Vector3(collision.transform.position.x,1, collision.transform.position.z); 
            print(enemy_location);
            Instantiate(coins, enemy_location,collision.transform.rotation);

        }
    }

   
}
