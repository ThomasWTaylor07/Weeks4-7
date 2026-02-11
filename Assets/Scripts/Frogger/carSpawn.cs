using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class carSpawn : MonoBehaviour

{
    public GameObject carPrefab;
    public int i;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
            Instantiate(carPrefab, transform.position, Quaternion.identity);
          
                 }
    }

