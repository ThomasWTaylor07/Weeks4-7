using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject duckPreFab;
    public List<GameObject> ducks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            spawn();
            
        }
    }


    public void spawn()
    {
        {
            Vector2 spawnPos = Random.insideUnitCircle * 4;
            Instantiate(duckPreFab, spawnPos, transform.rotation);
            ducks.Add(duckPreFab);
        }
    }
}


