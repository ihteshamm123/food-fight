using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 30;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        //        if (Input.GetKeyDown(KeyCode.S))
        //        {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawmPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawmPos
            , animalPrefabs[animalIndex].transform.rotation);
        //        }
    }
}
