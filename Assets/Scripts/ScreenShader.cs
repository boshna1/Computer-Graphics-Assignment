using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShader : MonoBehaviour
{
    public Shader shader;
    public Material renderMaterial;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit (source, destination, renderMaterial);
    }
}
