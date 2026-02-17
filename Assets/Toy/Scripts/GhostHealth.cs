using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GhostHealth : MonoBehaviour
{
    //Initializes a slider object variable that is used by the slider that is a child of the ghost so that its values can be changed
    public Slider healthbar;
    //Gets access to the ghosts sprite renderer so that it can change colour and recognize when the mouses over its sprite 
    public SpriteRenderer ghost;
    //Sets the value of each ghosts health so that it can be displayed by the health bar and have its values changed by the mouse
    public float health = 50;
    //Initializes a variable that checks whether the health variable is equal to 0 so that it can be used by the ghost spawner
    public bool noHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the health bar maximum health to the health variable so that the slider can be filled when the ghost is at full health
        healthbar.maxValue = health;
        //Sets the sliders value at all times to be the same as the health variable so that the slider can update based on the ghosts health
        healthbar.value = health;
        //Initializes a vector3 and assigns it to the objects rotation variable so that it can change the objects rotation
        Vector3 newRotate = transform.eulerAngles;
        //Sets the z value of the Vector3 to a random number so that the ghosts rotation on the z axis can be randomized each time it gets instantiated
        newRotate.z = Random.Range(1,360);
     //Reassigns the ghosts rotation back to the value of the Vector3 so each time its instantiated, it gets a random rotation on the z axis 
        transform.eulerAngles = newRotate;
    }

    // Update is called once per frame
    void Update()
    {
        //Initializes a vector2 and sets its value to the mosuses position so the code can check where the mouse is in relation to the ghost
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Checks to see if the mouses position is within the bounding box of the ghosts sprite render to determie whether to lower its health
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
        //If the health vairable is at 0, a boolean that is accessed by the ghost spawner script is set to true so it knows when a ghost has no health
            noHealth = true;
        }
        else
        {
        //If the health variable is above 0, that same boolean is set to false which tells the ghosts spawner not to destroy the ghost
            noHealth = false;
        }
        
    }
    
    }


