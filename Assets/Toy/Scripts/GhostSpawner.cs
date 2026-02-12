using UnityEngine;
using UnityEngine.InputSystem;

public class GhostSpawner : MonoBehaviour
{
    public float timerMax = 5;
    public float timerValue = 0;
    public GameObject prefab;
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
            

         Instantiate(prefab, spawnPos, Quaternion.identity);
         timerValue = 0;

        }
        
    }
}
