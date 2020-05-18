using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void exitgame()
    {
        Debug.Log("Game Over!");
        Application.Quit(); 
    }
    public void Restart()
    {
        Debug.Log("Restart!");
        Application.LoadLevel("Prototype 2");
    }
    public void level()
    {
        Debug.Log("Restart!");
        Application.LoadLevel("Level");
    }
    public void main()
    {
        Debug.Log("Restart!");
        Application.LoadLevel("Main");
    }
}
