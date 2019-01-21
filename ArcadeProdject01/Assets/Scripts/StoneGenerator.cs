using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour {


    public GameObject[] enemies;
    public Transform[] spawnpointsL;
    public Transform[] spawnpointsR;
    private float count = 0;
    [SerializeField] string[] listOfPossibleTags;
    [SerializeField] GameObject[] objectspawn; 
    [SerializeField] float timeBetweenSpawns = 3.0f; 







}
