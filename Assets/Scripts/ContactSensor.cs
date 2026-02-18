using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnteringSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position) == true)

            if (isInHazard == true)
            {

            }
            else
            {
                Debug.Log("Entered The Sensor");
                isInHazard = true;
                OnEnteringSensor.Invoke();
            }
        else
        {
            if (isInHazard == true)
            {
                Debug.Log("Exited The Sensor");
                isInHazard = false;
                OnExitSensor.Invoke();
                OnRandomNumber.Invoke(Random.Range(5f, 8f));
            }
        }
  
    }
    public void ShowNumber(float number)
    {
        Debug.Log(number);
    
    }
}

