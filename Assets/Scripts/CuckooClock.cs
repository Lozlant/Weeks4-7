using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuckooClock : MonoBehaviour
{
    public float speed;
    int hour=1;
    float playTimes = 0;
    public AudioSource aus;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -speed * Time.deltaTime);
        float actualHour = ((-transform.eulerAngles.z) / 30 + 12) % 12;
        if (actualHour > hour || actualHour > 0 && hour==12 && actualHour < 1) // The actual hour is greater than the recorded hour
        {
            playTimes = hour;
            //aus.Play();
            //print(hour + "play");
            hour = hour % 12 + 1;
        }
        if(!aus.isPlaying && playTimes > 0)
        {
            playTimes--;
            aus.Play();
        }
            bird.SetActive(aus.isPlaying);
        
    }
}
