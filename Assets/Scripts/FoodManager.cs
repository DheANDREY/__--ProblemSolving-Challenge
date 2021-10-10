using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    public GameObject food;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	public SpawnController spaCo;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Spawn", spawnTime, spawnTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void Spawn()
	{
        //Jika player telah mati maka tidak membuat enemy baru
        /* if (playerHealth.currentHealth <= 0f)
        {
            return;
        } */

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);

        //Memduplikasi enemy
        Instantiate(food, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
       // Factory.FactoryMethod(spawnEnemy);
	}
}

