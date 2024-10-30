using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timer;
    [SerializeField] GameObject canvas;
    [SerializeField] Text endText;
    [SerializeField] Dirt dirt;
    float time = 0f;
    void Update()
    {
        time += Time.deltaTime;
        timer.text = "Time: " + System.Math.Round(time,2);
        if (time >= 300)
        {
            canvas.SetActive(true);
            endText.text = "Congratulations!\nYou completed the night shift\nJobs Completed: " + dirt.GetJobsCompleted();
        }
    }
}
