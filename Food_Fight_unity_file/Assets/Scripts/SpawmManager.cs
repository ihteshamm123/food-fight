using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{

    private float startDelay = 2;
    private float spawnInterval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawmPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawmPos
                , animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
