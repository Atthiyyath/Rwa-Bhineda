using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 180f; // 2 menit 30 detik
    public Text timeText;
    public GameObject GameOver;

    void Start()
    {
        GameOver.SetActive(false);
    }

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            GameOver.SetActive(true);
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 30);
        float seconds = Mathf.FloorToInt(timeToDisplay % 30);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}