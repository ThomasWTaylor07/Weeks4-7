using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void toggleSpace()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
        //if the game object is active, turn it off: call set active and pass true
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);

        //}
        //else if (gameObject.activeInHierarchy == false)
        //{
        //    //if the game object is inactive, turn it on: call setActive and pass true
        //    gameObject.SetActive(true);
           
        }
    }

