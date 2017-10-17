Shader "Custom/NewSurfaceShader" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_AO ("AO", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		
		CGPROGRAM

		#pragma surface surf Standard fullforwardshadows

		sampler2D _MainTex;
		sampler2D _AO;

		struct Input {
			float2 uv_MainTex;
		
		};

		half _Glossiness;
		half _Metallic;


		void surf (Input IN, inout SurfaceOutputStandard o) {

			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			fixed4 d = tex2D(_AO, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Occlusion = d.r;
			o.Metallic = c.a-0.5;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
