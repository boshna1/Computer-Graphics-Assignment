Shader "ScrollingVariant"
{
    Properties
    {
         _MainTex("Albedo (RGB)",2D) = "white" {}
        _ScrollZ("Scroll X", Range(-5,5)) = 1
        _Scale("Scale", Range(0,50)) = 0
    }
    
    SubShader
    {
  
        Tags{"Queue" = "Transparent"}
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off
        CGPROGRAM

    #pragma surface surf Lambert alpha:blend
    float _ScrollZ;
    float _Scale;

    sampler2D _MainTex;
    struct Input
    {
        float2 uv_MainTex;
    };

    void surf (Input IN, inout SurfaceOutput o)
    {
        _ScrollZ *= _Time * _Scale;
        float2 newuv = IN.uv_MainTex + float2(_ScrollZ,0);
        fixed4 texColor = tex2D(_MainTex,newuv);
        o.Albedo = tex2D(_MainTex, newuv);
        o.Alpha = texColor.a;
    }
    ENDCG
    }
FallBack "Diffuse"
}