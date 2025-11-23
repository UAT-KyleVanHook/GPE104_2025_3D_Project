using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    [Header("Game Bounds")]
    public int MaxXBounds;
    public int MaxYBounds;
    public int MaxZBounds;

    public int MinXBounds;
    public int MinYBounds;
    public int MinZBounds;

    [Header("Number of Entities Spawned at spawn points")]
    public int entitiesSpawned;

    //make this a singleton
    public static LevelData levelInstance;

    //public list of SpawnPoints
    public List<SpawnPoints> spawnPointsList;

    private float randSpawnAmount;
    private float randSpawnCount;


    void Awake()
    {

        if (levelInstance == null)
        {
            levelInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //make a new list for spawnPoints
        spawnPointsList = new List<SpawnPoints>();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //keep this here
        //putting this in the awake doesn't allow the game to work
        //max bounds
        GameManager.instance.maxX = MaxXBounds;
        GameManager.instance.maxY = MaxYBounds;
        GameManager.instance.maxZ = MaxZBounds;

        //min bounds
        GameManager.instance.minX = MinXBounds; 
        GameManager.instance.minY = MinYBounds;
        GameManager.instance.minZ = MinZBounds;

        //set randSpawnCount to 0

        randSpawnCount = 0;

        //set the randSpawnAmount to a random amount based on the list size
        randSpawnAmount = UnityEngine.Random.Range(1, spawnPointsList.Count);

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(spawnPointsList.Count);

        while(randSpawnCount < randSpawnAmount)
        {
            //get a random number from the start of the list to the max
            float randNum = UnityEngine.Random.Range(0, spawnPointsList.Count);

            //Convert that number to an int
            int spawnPointNum = (int)randNum;

            //spawnObject method in the selected point
            spawnPointsList[spawnPointNum].SpawnObject(entitiesSpawned);

            randSpawnCount++;

        }
        
    }
}
