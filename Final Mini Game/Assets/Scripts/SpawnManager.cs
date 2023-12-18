using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int coinAmount = 10;
    public float areaRange = 45f;
    public GameObject collectibleOnject;
    public GameObject enemyObject;

    // Start is called before the first frame update
    void Start()
    {
         //SpawnEnemyObject();
         StartCoroutine(SpawnRandomAmountOfenemies());
         SpawnCollectibleObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemyObject() 
    {
        Instantiare(enemyObject, RandomSpawnPosition(), enemyObject.transform.rotation);
    }

    public void SpawnCollectibleObject()
    {
        Instantiate(CollectibleObject, RandomSpawnPosition(), collectibleObject.transform);
    }
    
    Vector3 RandomSpawnPosition()
    {
    Vector3 RandomSpawnPosition = new Vector3(Random.Ramnge(-areaRange, areaRange), If, Random.Range(-areaRange, areaRange));

    return spawnPosition;
    }

    IEnumerator SpawnRandomAmoundOfEnemies()
    {
        float randomSeconds = Random.Range(1, 5);

        yield return new WaitForSeconds(randomSeconds);

        int numberOfEnemies = Random.Range(1, 5);

        for(int i = 0; i < numberOfEnemies; i++)
        {
            Instantiate(enemyObject, RandomSpawnPosition(), enemyObject.transform.rotation);
        }
    }
}
