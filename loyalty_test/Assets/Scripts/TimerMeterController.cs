using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMeterController : MonoBehaviour
{
    public float startTime = 10.0f;
    private float targetTime;
    public float maxPainVolume = 0.2f;

    public Slider mySlider;
    public AudioSource pain;

    void Start()
    {
        targetTime = startTime;
    }
    
    void Update()
    {
        //print(targetTime);
        //mySlider.value += increment;

        targetTime -= Time.deltaTime;

        //mySlider.value = (startTime - targetTime/startTime);
        mySlider.value = (startTime - targetTime) / startTime;
        pain.volume = maxPainVolume * mySlider.value;

        if (mySlider.value >= 1.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {

        //do your stuff here.
        FindObjectOfType<GameManager>().EndGame();
        //print("you shit yourself");
    }


}
