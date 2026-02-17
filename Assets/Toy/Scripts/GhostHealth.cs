using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GhostHealth : MonoBehaviour
{
    //Initializes a slider object variable that is used to get the child slider of the ghost and change its values
    public Slider healthbar;
    //Gets access to the ghosts sprite renderer so that it can recognize when the mouses over the sprite 
    public SpriteRenderer ghost;
    //Sets the value of each ghosts health so that it can be displayed by the health bar and have its values changed by the mouse
    public float health = 50;
    //Initializes a variable that checks whether the health variable is equal to 0 so that it can be used by the Ghost Spawner
    public bool noHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the sliders maximum value to the health variable so that the slider can be filled when the ghost is at full health
        healthbar.maxValue = health;
        //Sets the sliders value to always be equal to the health variable so that the slider can update based on the ghost's health
        healthbar.value = health;
        //Initializes a Vector3 and assigns it to the ghost's rotation variable so that it can change the ghost's rotation
        Vector3 newRotate = transform.eulerAngles;
        //Sets the Z value of the Vector3 to a random number so that the ghost's rotation can be randomized each time it's used
        newRotate.z = Random.Range(1,360);
     //Reassigns the ghost's rotation back to the value of the Vector3 so each time its instantiated, it gets a random rotation
        transform.eulerAngles = newRotate;
    }

    // Update is called once per frame
    void Update()
    {
        //Initializes a Vector2 and sets its value to the mosuse's position so the code can check where the mouse is at all times
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
     //Checks to see if the mouse's position overlaps the bounding box in the sprite render to determine whether to lower the ghost's health
        if (ghost.bounds.Contains(mousePos))
        {
            //If the mouse is within the bounding box, its health varible decreases by a small amount  
            health -= 0.01f;
            //That value then gets inputeed back into the slider used for the health bar so that it can relfect the ghost's current health
            healthbar.value = health;
        }

        //Checks if the health variable is equal to 0 so it can determine whether it has no health and set the value of a boolean
        if (health <= 0)
        {
        //If the health vairable is at 0, a boolean that is set to true so the Ghost Spawner script knows when a ghost has no health
            noHealth = true;
        }
        else
        {
        //If the health variable is above 0, that same boolean is set to false which tells the Ghosts Spawner to not do anything
            noHealth = false;
        }
        
    }
    
    }
//Image Credits:
//Ghost: https://www.baamboozle.com/game/1213919 uploaded by Baamboozle 
//Background:https://www.freepik.com/free-vector/old-abandoned-house-hallway-night_7588760.htm#fromView=keyword&page=1&position=0&uuid=41481d7d-640a-450e-8b74-5ddea63245cb&query=Creepy+basement uploaded by upklyak


