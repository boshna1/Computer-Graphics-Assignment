using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobSpawner : MonoBehaviour
{
    [SerializeField] Transform[] DirtSpawns;
    [SerializeField] GameObject Dirt;
    bool jobComplete = true;
    int maxJobCount = 5;
    int currentJobs;
    [SerializeField] Text jobCounter;

    void Update()
    {
        if (currentJobs == 0)
        {
            jobComplete = true;
        }

        jobCounter.text = "Job's left: " + currentJobs;
        if (jobComplete) 
        {
            ResetJobs();
        }
    }

    void ResetJobs()
    {
        for (int i = 0; i < maxJobCount; i++)
        {
            int random = Random.Range(0,DirtSpawns.Length);
            Instantiate(Dirt, DirtSpawns[random]);
        }
        jobComplete = false;
        currentJobs = maxJobCount;
        maxJobCount += 3;
    }

    public void DecreaseJob()
    {
        currentJobs--;
    }
}
