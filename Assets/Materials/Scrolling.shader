Shader "Scrolling"
{
    Properties
    {
        [PerRendererData] _MainTex("Albedo (RGB)",2D) = "white" {}
        _ScrollX("Scroll X", Range(-5,5)) = 1
        _ScrollY("Scroll Y", Range(-5,5)) = 1
        _RainScale("Scale", Range(0,50)) = 0
    }
    
    SubShader
    {
  
        Tags{"Queue" = "Transparent"}
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off
        CGPROGRAM

    #pragma surface surf Lambert alpha:blend
    float _ScrollX;
    float _ScrollY;
    float _RainScale;

    sampler2D _MainTex;
    struct Input
    {
        float2 uv_MainTex;
    };

    void surf (Input IN, inout SurfaceOutput o)
    {
        _ScrollX *= _Time * _RainScale;
        _ScrollY *= _Time * _RainScale;
        float2 newuv = IN.uv_MainTex + -float2(_ScrollX,_ScrollY);
        fixed4 texColor = tex2D(_MainTex,newuv);
        o.Albedo = tex2D(_MainTex, newuv);
        o.Alpha = texColor.a;
    }
    ENDCG
    }
FallBack "Diffuse"
}