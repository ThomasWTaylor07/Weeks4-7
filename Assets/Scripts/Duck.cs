using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Duck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //was the button pressed this frame & we are not pointing at the UI?
       if (Mouse.current.leftButton.wasPressedThisFrame && EventSystem.current.IsPointerOverGameObject() == false)
        {
            //Y: Set the position to the mouse position 
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }

    }
}
