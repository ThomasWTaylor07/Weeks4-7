using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GhostSpawner : MonoBehaviour
{
    //Intializes a variable that sets the max time it takes for a prefab to be instantiated and for the timer to be reset
    public float timerMax = 5;
    //Initializes a varibale that acts as the starting value of the timer that then gets increased by time.DeltaTime
    public float timerValue = 0;
    //Gives the Ghost Spawner script access to the Ghost Health script allowing each prefab to access it from the inspector 
    public GhostHealth ghealth;
    //Creates a list of each ghost prefab in the scene so that ghosts can be destroyed and changed from within the script
    public List<GameObject> ghosts;
    //Allows the script to get access to the ghost prefab as long as it is placed in the inspector so it can be instantiated
    public GameObject ghost;
    //Turns each ghost that is instatiated into a game object that can then be added to a list of instatiated game objects
    public GameObject spawnedGhosts;
    //Creates a public sprite rended varible that is used to get the sprite renderer of the ghost prefab from the inspector
    public SpriteRenderer sr;
    //Initializes an integer that counts how many ghosts have been destroyed within the scene so it can be displayed in the UI
    public int howManyGhosts;
    //Gets access to text within the UI so that it can be changed to show the value of the howManyGhosts integer
    public TextMeshProUGUI score;
    //Gets the audio source from within the Ghost Spawner object so it can be used to play diffrent sound effects
    public AudioSource audioSource;
    //Gets an audio clip that's set in the inspector so it can be played by the audio source whenever a ghost is instantiated
    public AudioClip spawn;
    //Gets an audio clip that's set in the inspector so it can be played by the audio source whenever a ghost is destroyed
    public AudioClip despawn;
    //Gets access to a slider component from the UI that will create a timer to show the time until the next ghost is instantiated
    public Slider timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the timers maximum value to the timerMaxs value so that it resets at the same time as the timerValue variable
        timer.maxValue = timerMax;

    }

    // Update is called once per frame
    void Update()
    {
       //Gives a textmesh object in the UI the value of the howManyGhosts varaible as a string so it can be shown on screen
        score.text = howManyGhosts.ToString();
        //Increments the value of a timer by delta time so that it can count up unitil it reach the time limit
        timerValue += Time.deltaTime;
        //Checks if the value of the timer has exceeded the maximum value its allowed so that something can happen every 5 seconds
        if (timerValue > timerMax)
        {
  //A vector2 is given random values that are used as the ghosts transform so that the ghosts are instantiated at a random spot
            Vector2 spawnPos = Random.insideUnitCircle * 4;
            //Instatiates a ghost prefab at a random position and turns it into a game object that gets added to a list 
            spawnedGhosts = Instantiate(ghost, spawnPos, Quaternion.identity);
            //Gives each instansiated ghost access to the Ghost Health script so they can have the same health functionallity
            GhostHealth ghealth = spawnedGhosts.GetComponent<GhostHealth>();
            //Sets the timer back to 0 so it can count the time unitil another 5 seconds have passed
            timerValue = 0;
            //Adds each spawned ghost to a list so that each ghost can be destroyed and change colours 
            ghosts.Add(spawnedGhosts);
            //Grabs an audio clip from the inspector and puts it into the audio source of the ghost spawner
            audioSource.clip = spawn;
            //Plays the audio clip in the audio source so the player knows when a ghost is spawned
            audioSource.Play();

        }
        //Updates the value of the timer in the UI so that it accuratley shows the value of the timerValue variable each frame
        timer.value = timerValue;
        //Grabs every ghost within the list so that it can check whether any of them have no health left
        for (int i = ghosts.Count - 1; i >= 0; i--)
        {
            //Gets each ghosts Ghost Health script so that the code can check whether an object has no health
            GhostHealth gihealth = ghosts[i].GetComponent<GhostHealth>();
       //Checks if the noHealth boolean in any of the ghosts Ghost Health script is equal to true to see whether it has no health 
            if (gihealth.noHealth == true)
            {
                //Gets the specific ghost game object from within the list and reassigns it to the value of a local game object
                GameObject ghost = ghosts[i];
                //Removes that game object from the list so that it does not try to get accessed by the script again
                ghosts.Remove(ghost);
                //Destroys the game object so that it no longer appears on screen or changes anything in the code
                Destroy(ghost);
                //A varible increments by 1 so that text in the UI can display how many ghosts have been destroyed
                howManyGhosts += 1;
                //The audiosource of the Ghost Spawner is given an audio clip to play to show that the object has been destroyed
                audioSource.clip = despawn;
                //The clip is then played by the audio source once to show when the ghost gets destroyed.
                audioSource.Play();
            }

        }
    }
    //Initializes a public function that is activated by a button in the UI
    public void colourChange()
    {
        //Checks for each ghost in the list so that every ghost in the scene can get their colour changed
        for (int ii = ghosts.Count - 1; ii >= 0; ii--)
        {
            //Gives the script access to each ghosts sprite render so its colour can be changed when a button is pressed
            SpriteRenderer sr = ghosts[ii].GetComponent<SpriteRenderer>();
            //Changes the colur value within each ghosts sprite renderer to a random value to change the colour of each ghost
            sr.color = Random.ColorHSV();
        }
    }
}


  
        
   

