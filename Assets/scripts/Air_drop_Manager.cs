using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air_drop_Manager : MonoBehaviour
{
    public GameObject PrefabCrate;
    public GameObject InstantiatedCrate;
    private float DropTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spawnPointX = Random.Range(-40, 40);
        int spawnPointY = Random.Range(2, 2);
        int spawnPointZ = Random.Range(-40 , 40);
        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        if (InstantiatedCrate == null)
        {
            
            DropTime += Time.deltaTime;

            if (DropTime >= 12f)
            {
                
                InstantiatedCrate = Instantiate(PrefabCrate, spawnPosition, Quaternion.identity);
                DropTime = 0;
            }
        }

    }
}
