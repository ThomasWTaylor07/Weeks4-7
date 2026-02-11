using UnityEngine;

public class Car : MonoBehaviour
{
    float speedX;
    public SpriteRenderer car;
    public Transform frog;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speedX = Random.Range(0.01f, 0.04f);
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 newPos = transform.position;
        newPos.x -= speedX;
        transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < -Screen.width)
        {
            newPos = transform.position;
            newPos.x = 10;
            transform.position = newPos;
            
        }
     if (car.bounds.Contains(frog.position)){ 

            Vector2 newFrog = frog.position;
            newFrog = new Vector2(0, -5);
            frog.position = newFrog;
        }
    }
}
