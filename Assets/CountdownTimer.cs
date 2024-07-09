using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float countdownTime = 60f; // 60 seconds
    private bool finished = false;

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            UpdateTimerDisplay();
            yield return new WaitForSeconds(1f);
            countdownTime -= 1f;
        }

        countdownTime = 0;
        UpdateTimerDisplay();
        Debug.Log("Countdown finished!");
        finished = true;
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(countdownTime / 60);
        int seconds = Mathf.FloorToInt(countdownTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public bool IsFinished()
    {
        return finished;
    }
}
