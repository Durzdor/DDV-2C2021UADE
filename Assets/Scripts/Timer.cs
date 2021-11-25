using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;   
    private bool finnished = false;

    void Start()
    {
        startTime = Time.time;
    }

   
    void Update()
    {
        if (finnished)
            return;

        //Calculating Minutes and seconds on the timer.
        float t= Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2"); // f2  for two decimals only.

        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finnished = true;
        timerText.color = Color.red;
    }
}
