using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Frog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speedX = 0.01f;
    float speedy = 0.01f;
    public bool ifLeft = false;
    public bool ifRight = false;
    public bool ifUp = false;
    public bool ifDown = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector2 newPos = transform.position;
            newPos.x -= speedX;
            transform.position = newPos;
        }
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector2 newPos = transform.position;
            newPos.x += speedX;
            transform.position = newPos;
        }
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            {
                Vector2 newPos = transform.position;
                newPos.y += speedy;
                transform.position = newPos;
            }
          
            }
        if (Keyboard.current.downArrowKey.isPressed == true)
        {
            {
                Vector2 newPos = transform.position;
                newPos.y -= speedy;
                transform.position = newPos;
                ifDown = true;
            }
            
        }
        
    }
}