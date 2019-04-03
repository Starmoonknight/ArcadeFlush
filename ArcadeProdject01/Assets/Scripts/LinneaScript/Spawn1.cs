using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Spawn1 : MonoBehaviour
{


    private GameObject[] spawnpointsL;
    private GameObject[] spawnpointsR;
    private float counter = 0;
    [SerializeField] string[] listOfPossibleTags;
    [SerializeField] GameObject[] originalPrefab;
    public float timeBetweenSpawns = 1.0f;
    GameObject[] EnemyPrefabCopy;


    private GameObject EnemyPrefabCopy1;
   //private GameObject EnemyPrefabCopy2;
   //private GameObject EnemyPrefabCopy3;
   //private GameObject EnemyPrefabCopy4;

    public bool GameON; 



    private void Awake()
    {
        spawnpointsL = GameObject.FindGameObjectsWithTag("LeftSpawn");
        spawnpointsR = GameObject.FindGameObjectsWithTag("RightSpawn");
    }

    private void Start()
    {
        EnemyPrefabCopy[1] = EnemyPrefabCopy1;
        //EnemyPrefabCopy[2] = EnemyPrefabCopy2;
        //EnemyPrefabCopy[3] = EnemyPrefabCopy3;
        //EnemyPrefabCopy[4] = EnemyPrefabCopy4;


        listOfPossibleTags = new string[2];
        originalPrefab = new GameObject[4];
        EnemyPrefabCopy = new GameObject[4];

    }


  



    private void Update()
    {
    
        if (GameON = true) 
        {
            counter += Time.deltaTime;
            if (counter > timeBetweenSpawns)
            {
                GameObject spawnedObject;


                spawnedObject = EnemyPrefabCopy1;
                EnemyPrefabCopy1 = (GameObject) Instantiate(originalPrefab[Random.Range(0, originalPrefab.Length)],
                spawnpointsL[Random.Range(0, spawnpointsL.Length)].transform.position,
                Quaternion.identity) as GameObject;

                spawnedObject = EnemyPrefabCopy1;
                EnemyPrefabCopy1 = (GameObject) Instantiate(originalPrefab[Random.Range(0, originalPrefab.Length)],
                spawnpointsR[Random.Range(0, spawnpointsR.Length)].transform.position,
                Quaternion.identity) as GameObject;

                spawnedObject.gameObject.tag = listOfPossibleTags[Random.Range(0, listOfPossibleTags.Length)];
                counter = 0;
            }
        }
    }


   
        


}
