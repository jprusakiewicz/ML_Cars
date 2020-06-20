using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceController : MonoBehaviour
{
    public Text timer;
    public Text laps;
    private int lapCount = 1;
    private int currentLap = 0;
    private bool finnished = false; 

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(finnished)
            return;
        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timer.text = minutes + ":" + seconds;
        laps.text = currentLap.ToString()+"/"+ lapCount.ToString();
    }

    public int GetNumberOfLaps()
    {
        return lapCount;
    }

    public void Finnish()
    {
        finnished = true;
        timer.color = Color.yellow;
    }
}
