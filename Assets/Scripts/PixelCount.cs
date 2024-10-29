using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PixelCount : MonoBehaviour
{
    [SerializeField] int Pixels;
    private void Update()
    {
        QualitySettings.pixelLightCount = Pixels;
    }
    
}
