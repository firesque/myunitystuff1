using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    string Name = "Evan";
    // Start is called before the first frame update
    int life = 5;
    void Awake()
    {
        Debug.Log("Hello");
    }
    void Start()
    {
        Debug.Log("World");
        Shoot(5);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Name);
        if (life < 1) {
            Debug.Log("Game Over");
                }
        else {
            Debug.Log("Playing");
        }
    }

    void Shoot(int data)
    {
        Debug.Log("Shooting");
        Debug.Log(data);
    }

}