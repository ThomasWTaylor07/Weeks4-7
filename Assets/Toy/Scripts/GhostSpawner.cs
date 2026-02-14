using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GhostSpawner : MonoBehaviour
{
    public float timerMax = 5;
    public float timerValue = 0;
    public GhostHealth ghealth;
    public List<GameObject> ghosts;
    public GameObject ghost;
    public GameObject spawnedGhosts;
    public int howManyGhosts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;
        if (timerValue>timerMax)
        {
            Vector2 spawnPos = Random.insideUnitCircle * 4;
            

    spawnedGhosts = Instantiate(ghost, spawnPos, Quaternion.identity);
         timerValue = 0;

            ghosts.Add(spawnedGhosts);


        }
        for (int i = ghosts.Count - 1; i >= 0; i--)
        {
            GhostHealth ghealth = ghosts[i].GetComponent<GhostHealth>();
            if (ghealth.noHealth == true)
            {
                GameObject ghost = ghosts[i];
                ghosts.Remove(ghosts[i]);
                Destroy(ghosts[i]); 
            }

        }
    }
}
