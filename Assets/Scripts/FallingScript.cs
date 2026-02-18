using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class FallingScript : MonoBehaviour
{
    public float speed = 0.1f;
    public SpriteRenderer Lara;
    public UnityEvent OnPlayerCollision;
    public UnityEvent OnNoCollision;
    public Boolean isCollided;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.y -= speed * Time.deltaTime;
        transform.position = newPos;
    }
}

       

