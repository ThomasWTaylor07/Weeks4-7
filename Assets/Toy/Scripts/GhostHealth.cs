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
        //Sets the sliders value to always be equal to the health variable so that the slider can update based on the ghosts health
        healthbar.value = health;
        //Initializes a Vector3 and assigns it to the objects rotation variable so that it can change the objects rotation
        Vector3 newRotate = transform.eulerAngles;
        //Sets the Z value of the Vector3 to a random number so that the ghosts rotation can be randomized each time it's used
        newRotate.z = Random.Range(1,360);
     //Reassigns the ghosts rotation back to the value of the Vector3 so each time its instantiated, it gets a random rotation
        transform.eulerAngles = newRotate;
    }

    // Update is called once per frame
    void Update()
    {
        //Initializes a Vector2 and sets its value to the mosuses position so the code can check where the mouse is at all times
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
       //Checks to see if the mouses position overlaps the bounding box in the sprite render to determine whether to lower its health
        if (ghost.bounds.Contains(mousePos))
        {
            //If the mouse is within the bounding box, its health varible decreases by a small amount  
            health -= 0.01f;
            //That value then gets inputeed back to the slider used for the health bar so it can relfect the ghosts current health
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


