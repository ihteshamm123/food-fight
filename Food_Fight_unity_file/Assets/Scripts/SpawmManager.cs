using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update()
    {
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
