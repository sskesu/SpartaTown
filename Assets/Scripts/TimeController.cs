using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public TMP_Text timeTxt;
    
    DateTime currentDate = DateTime.MinValue;
    public string currentTime = "";


    private void Update()
    {
        currentDate = DateTime.Now;
        currentTime = currentDate.ToString("HH : mm");
        TimeCheck(currentTime);
    }

    private void TimeCheck(string time)
    {
        timeTxt.text = time;
    }
}
