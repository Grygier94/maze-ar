using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime;
    public Text counter;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        int seconds = (int)(Time.time - startTime) % 60;
        string secondsInString = seconds < 10 ? "0" + seconds : seconds.ToString();
        string minutes = (seconds / 60).ToString();
        counter.text = minutes + ":" + secondsInString;
    }
    public static void restartTimer() => Start();
}
