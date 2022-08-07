using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public Text timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    

    void Update()
    {
        UpdateTimerUI();
    }
    
    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        
        timerText.GetComponent<Text>().text = hourCount + "h" + minuteCount + "m" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }
}
