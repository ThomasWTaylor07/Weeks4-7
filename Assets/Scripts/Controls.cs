using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    SpriteRenderer sr;
    public AudioSource audioSource;
    public AudioClip boomSFX;



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
    public void SetRotation(float degrees)
    {
        transform.localEulerAngles = Vector3.one * degrees;
    }
    public void playSound()
    {
        audioSource.clip = boomSFX;
        audioSource.Play();
    }

}
