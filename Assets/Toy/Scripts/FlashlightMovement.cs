using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Initializes and assigns a new Vector2 that can that can change the value of the game objects transform
        Vector2 newPos = transform.position;
        //Converts the mouses position on screen to a Vector2 so the mouse can move the game object
        newPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Reassigns the objects positin to the value of the Vector2 to allow the mouses position to change the objects position
        transform.position = newPos;
    }

    //Initializes a new function that features a float as an argument that can then be accesed and changed by the slider
   public void LightScale(float scale)
    {
   //Sets the objects scale to 1 multiplied by the sliders value, allowing for the game object to change its scale based on the slider
        transform.localScale = Vector3.one * scale;

    }
}
