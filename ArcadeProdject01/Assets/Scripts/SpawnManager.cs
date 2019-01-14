using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 300f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    //public BombScript bombScript;
    public bool SpawnOn = false;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.




    }


    void Update()
    {

        /* if (bombScript.Bombs = 2)
            SpawnOn = true;
            */           

    }


    void FixedUpdate()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);

        if (SpawnOn == false)
        {
            CancelInvoke();

        }
    }


    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}