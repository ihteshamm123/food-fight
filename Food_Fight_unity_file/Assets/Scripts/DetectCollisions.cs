using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //if (a == 4)
        //{
            Destroy(other.gameObject);
            SceneManager.LoadScene("New Scene");
            Debug.Log("Game Over!");
        //}


    }
}
