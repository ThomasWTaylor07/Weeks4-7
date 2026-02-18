using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpikeSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject spike;
    public List<GameObject> spikes;
    public GameObject spawnedSpikes;
    public SpriteRenderer Lara;
    public UnityEvent OnPlayerCollision;
    public UnityEvent OnNoCollision;
    public Boolean isCollided;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn()
    {
     spawnedSpikes = Instantiate(spike);
        spikes.Add(spawnedSpikes);

        for (int i = 0; i < spikes.Count; i++) {
            if (Lara.bounds.Contains(spikes[i].transform.position))
            {

                if (isCollided == true)
                {

                }
                else
                {
                    Debug.Log("AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH");
                    isCollided = true;
                    OnPlayerCollision.Invoke();

                }
            }
            else
            {
                if (isCollided == true)
                {
                    isCollided = false;
                    OnNoCollision.Invoke();
                }
            }
        }
    }
}
    
    
