using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    //object to spawn
    public GameObject spawnObject;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //add to Leveldata spawnPoint list
        LevelData.levelInstance.spawnPointsList.Add(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject(int amount)
    {
        //set check to see how many objects are spwned
        int spawnCount = 0;

        while (spawnCount < amount)
        {


            Debug.Log("Spawning: " + spawnObject.name);

            //randomize the heights obejcts are spwned.
            Vector3 newTransform = new Vector3(transform.position.x + Random.Range(-5.0f,5.0f), transform.position.y + Random.Range(-5.0f, 5.0f), transform.position.z + Random.Range(-5.0f, 5.0f));

            //instantiate the object
            Instantiate(spawnObject, newTransform, Quaternion.identity);

            //increment
            spawnCount++;

        }


    }
}
