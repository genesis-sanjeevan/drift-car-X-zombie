using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Air_Drop : MonoBehaviour
{
       
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(true);
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        
        }    
         
    }

    

}
