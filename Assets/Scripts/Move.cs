using UnityEngine;

public class Move : MonoBehaviour
{
   SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void ChangeColourValue()
    {
        sr.color = Random.ColorHSV();

    }
}
