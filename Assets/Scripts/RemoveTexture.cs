using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTexture : MonoBehaviour
{
    Material storeMaterial;
    Material[] storeMaterials = new Material[2];
    [SerializeField] Material BlankMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7)) 
        {
            storeMaterial = GetComponent<MeshRenderer>().material;
            GetComponent<MeshRenderer>().material = BlankMaterial;
        }
        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            GetComponent<MeshRenderer>().material = storeMaterial;
        }

    }
}
