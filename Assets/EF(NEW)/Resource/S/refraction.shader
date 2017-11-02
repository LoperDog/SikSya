Shader "Custom/refraction" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_GG ("GG", float) = 0.1
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Transparent"}
		LOD 200

		GrabPass{}

		CGPROGRAM
		#pragma surface surf Lambert

		float _GG;
		sampler2D _GrabTexture;
		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
			float4 screenPos;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex + _Time.x);
			//o.Albedo = c.rgb;
			float2 screenUV = IN.screenPos.rgb/ IN.screenPos.a;
			screenUV = float2(screenUV.r , 1-screenUV.g);
			//o.Emission = float3(screenUV, 0);
			o.Emission = tex2D(_GrabTexture, screenUV+c.r * _GG);
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Regacy shaders/Transparent/Diffuse"
}
