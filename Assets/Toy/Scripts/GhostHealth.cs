using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GhostHealth : MonoBehaviour
{
    public Slider healthbar;
    public SpriteRenderer ghost;
    public float health = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      healthbar.maxValue = health;
        healthbar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (ghost.bounds.Contains(mousePos))
        {
            health -= 0.01f;
            healthbar.value = health;
        }
    }
}
