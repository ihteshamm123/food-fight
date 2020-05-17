using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        a++;
        if (a == 4)
        {
            Destroy(other.gameObject);
            Debug.Log("Game Over!");


        }
    }
}
