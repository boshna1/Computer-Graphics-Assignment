using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dirt : MonoBehaviour
{
    bool isLooked = false;
    float timeCleaned = 0;
    bool finishClean;
    [SerializeField] Slider slider;
    [SerializeField] Text timed;
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("Interact");
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLooked && Input.GetKey(KeyCode.E))
        {
            slider.gameObject.SetActive(true);
            timed.gameObject.SetActive(true);
            timeCleaned += Time.deltaTime;
            slider.value = timeCleaned / 3;
            timed.text = System.Math.Round(((float)(timeCleaned)), 2).ToString();
        }
        if (!isLooked || Input.GetKeyUp(KeyCode.E)) 
        {
            slider.gameObject.SetActive(false);
            timed.gameObject.SetActive(false);
            timeCleaned = 0;
            slider.value = 0;
            timed.text = "";
        }
        if (timeCleaned >= 3f)
        {
            slider.gameObject.SetActive(false);
            timed.gameObject.SetActive(false);
            Debug.Log("Finish Clean");
            finishClean = true;
            timeCleaned = 0;
            slider.value = 0;
            timed.text = "";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag != "Dirt")
        {
            isLooked = false;
        }
        if (other.transform.tag == "Dirt")
        {
            Debug.Log("Enter");
            isLooked = true;
            other.transform.GetChild(0).gameObject.SetActive(true);
            text.gameObject.SetActive(true);
        }
        
        
    }
    void OnTriggerExit(Collider other)
    { 
        if (other.transform.tag == "Dirt")
        {
            Debug.Log("Exit");
            isLooked = false;
            other.transform.GetChild(0).gameObject.SetActive(false);
            text.gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (finishClean && other.transform.tag == "Dirt") 
        {
            Debug.Log("destroy");   
            Destroy(other.transform.gameObject);
            GameObject.FindGameObjectWithTag("JobHolder").GetComponent<JobSpawner>().DecreaseJob();
            finishClean = false;
            text.SetActive(false);
        }
    }
}
