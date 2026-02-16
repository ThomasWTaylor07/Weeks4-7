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

       Mathf.Clamp(newPos.y, -0.7f, 0.7f);
        Mathf.Clamp(newPos.x, -12, 12);
    }

   public void LightScale(float scale)
    {
        transform.localScale = Vector3.one * scale;

    }
}
