using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggles : MonoBehaviour
{
    GameObject[] AmbientLights;
    GameObject[] SpecularLights;
    GameObject[] Shaders;
    // Start is called before the first frame update
    void Start()
    {
        AmbientLights = GameObject.FindGameObjectsWithTag("Ambient");
        SpecularLights = GameObject.FindGameObjectsWithTag("Specular");
        Shaders = GameObject.FindGameObjectsWithTag("Shader");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            for (int i = 0; i < AmbientLights.Length; i++) 
            {
                AmbientLights[i].SetActive(false);
            }
            for (int i = 0; i < SpecularLights.Length; i++)
            {
                SpecularLights[i].SetActive(false);
            }
            for (int i = 0; i < Shaders.Length; i++)
            {
                Shaders[i].GetComponent<MeshRenderer>().enabled = false;
            }

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < AmbientLights.Length; i++)
            {
                AmbientLights[i].SetActive(true);
            }
            for (int i = 0; i < SpecularLights.Length; i++)
            {
                SpecularLights[i].SetActive(false);
            }
            for (int i = 0; i < Shaders.Length; i++)
            {
                Shaders[i].GetComponent<MeshRenderer>().enabled = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < AmbientLights.Length; i++)
            {
                AmbientLights[i].SetActive(false);
            }
            for (int i = 0; i < SpecularLights.Length; i++)
            {
                SpecularLights[i].SetActive(true);
            }
            for (int i = 0; i < Shaders.Length; i++)
            {
                Shaders[i].GetComponent<MeshRenderer>().enabled = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < AmbientLights.Length; i++)
            {
                AmbientLights[i].SetActive(true);
            }
            for (int i = 0; i < SpecularLights.Length; i++)
            {
                SpecularLights[i].SetActive(true);
            }
            for (int i = 0; i < Shaders.Length; i++)
            {
                Shaders[i].GetComponent<MeshRenderer>().enabled = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            for (int i = 0; i < AmbientLights.Length; i++)
            {
                AmbientLights[i].SetActive(true);
            }
            for (int i = 0; i < SpecularLights.Length; i++)
            {
                SpecularLights[i].SetActive(true);
            }
            for (int i = 0; i < Shaders.Length; i++)
            {
                Shaders[i].GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
