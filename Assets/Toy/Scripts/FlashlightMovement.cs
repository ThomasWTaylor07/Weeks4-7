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
        Vector2 newPos = transform.position;
        newPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = newPos;
    }

   public void LightScale(float scale)
    {
        transform.localScale = Vector3.one * scale;

    }
}
