using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceController : MonoBehaviour
{
    public Text timer;
    public Text laps;
    public Text countDown;
    private int lapCount = 1;
    private int currentLap = 0;
    private bool finnished = false;
    private int integer;
    private bool canDrive = false;
    private string minutes = "0";
    private string _seconds = "0";
    private int place = 0;
    private string finaltime;
    private bool playerfinished = false;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Countdown");

    }

    // Update is called once per frame
    void Update()
    {
        if (canDrive)
        {
            if (finnished)
                return;
            float t = Time.time - startTime;
            minutes = ((int) t / 60).ToString();
            _seconds = (t % 60).ToString("f2");
            
        }
        if(integer == 0)
            countDown.gameObject.SetActive(false);
        countDown.text = integer.ToString();
        timer.text = minutes + ":" + _seconds;
        laps.text = "lap: " + currentLap.ToString() + "/" + lapCount.ToString();
    }

    // private void CountDown()
    // {
    //     
    // }

    IEnumerator Countdown()
    {
        float duration = 3f; // 3 seconds you can change this to
        //to whatever you want
        float totalTime = 0;
        while(totalTime <= duration)
        {
            //countdownImage.fillAmount = totalTime / duration;
            totalTime += Time.deltaTime;
            integer = 3 - (int)totalTime; /* choose how to quantize this */
            /* convert integer to string and assign to text */
            yield return null;
        }
        GameObject.Find("SportsCar_1").SendMessage("EnableControl");
        GameObject.Find("SportsCar_2").SendMessage("EnableControl");
        GameObject.Find("SportsCar_3").SendMessage("EnableControl");
        GameObject.Find("SportsCar_4").SendMessage("EnableControl");
        GameObject.Find("SportsCar_5").SendMessage("EnableControl");
        GameObject.Find("SportsCar_player").SendMessage("EnableControl");
        startTime = Time.time;
        canDrive = true;
    }
    public int GetNumberOfLaps()
    {
        return lapCount;
    }

    public void Finnish()
    {
        finnished = true;
        timer.color = Color.green;
        finaltime = minutes + ":" + _seconds;
        playerfinished = true;
    }
    public void EnemyFinnish()
    {
        if (!playerfinished)
        {
            place++;
            timer.color = Color.red;
        }
    }
}
