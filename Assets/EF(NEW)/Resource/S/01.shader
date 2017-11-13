// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33635,y:32082,varname:node_4795,prsc:2|emission-9842-OUT,alpha-798-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32235,y:32605,varname:_MainTex,prsc:2,tex:043350eb21d42884984995acc56bbcea,ntxv:0,isnm:False|UVIN-7408-OUT,TEX-2368-TEX;n:type:ShaderForge.SFN_Multiply,id:2393,x:32753,y:32556,varname:node_2393,prsc:2|A-6074-RGB,B-2053-RGB,C-797-RGB,D-7688-OUT,E-2190-RGB;n:type:ShaderForge.SFN_VertexColor,id:2053,x:32235,y:32772,varname:node_2053,prsc:2;n:type:ShaderForge.SFN_Color,id:797,x:32235,y:32929,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:798,x:32774,y:32800,varname:node_798,prsc:2|A-6074-A,B-2053-A,C-797-A;n:type:ShaderForge.SFN_TexCoord,id:8327,x:31171,y:31755,varname:node_8327,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:769,x:31918,y:31969,varname:node_769,prsc:2|A-4117-OUT,B-551-OUT;n:type:ShaderForge.SFN_Time,id:5953,x:31169,y:32045,varname:node_5953,prsc:2;n:type:ShaderForge.SFN_Add,id:551,x:31578,y:31957,varname:node_551,prsc:2|A-8327-V,B-5452-OUT;n:type:ShaderForge.SFN_Multiply,id:5452,x:31389,y:32075,varname:node_5452,prsc:2|A-5953-T,B-6649-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6649,x:31146,y:32254,ptovrint:False,ptlb:time,ptin:_time,varname:node_6649,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Set,id:5736,x:32219,y:31985,varname:Time_1,prsc:2|IN-769-OUT;n:type:ShaderForge.SFN_Get,id:7408,x:31966,y:32615,varname:node_7408,prsc:2|IN-5736-OUT;n:type:ShaderForge.SFN_Multiply,id:4779,x:31404,y:32348,varname:node_4779,prsc:2|A-5953-T,B-6128-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6128,x:31150,y:32513,ptovrint:False,ptlb:Time_2,ptin:_Time_2,varname:node_6128,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:7348,x:31918,y:32199,varname:node_7348,prsc:2|A-8327-U,B-7200-OUT;n:type:ShaderForge.SFN_Add,id:7200,x:31668,y:32311,varname:node_7200,prsc:2|A-8327-V,B-4779-OUT;n:type:ShaderForge.SFN_Set,id:5144,x:32197,y:32229,varname:Time_2,prsc:2|IN-7348-OUT;n:type:ShaderForge.SFN_Tex2d,id:2190,x:32235,y:32406,varname:_MainTex_copy,prsc:2,tex:043350eb21d42884984995acc56bbcea,ntxv:0,isnm:False|UVIN-1240-OUT,TEX-2368-TEX;n:type:ShaderForge.SFN_Get,id:1240,x:31966,y:32384,varname:node_1240,prsc:2|IN-5144-OUT;n:type:ShaderForge.SFN_Add,id:4117,x:31559,y:31722,varname:node_4117,prsc:2|A-1778-OUT,B-8327-U;n:type:ShaderForge.SFN_Vector1,id:1778,x:31379,y:31630,varname:node_1778,prsc:2,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:7688,x:32224,y:33087,ptovrint:False,ptlb:node_7688,ptin:_node_7688,varname:node_7688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Fresnel,id:2181,x:32491,y:32255,varname:node_2181,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9583,x:32868,y:32286,varname:node_9583,prsc:2|A-7595-RGB,B-3302-OUT;n:type:ShaderForge.SFN_Color,id:7595,x:32440,y:32014,ptovrint:False,ptlb:node_7595,ptin:_node_7595,varname:node_7595,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Add,id:9842,x:33276,y:32249,varname:node_9842,prsc:2|A-9583-OUT,B-2393-OUT,C-8900-OUT;n:type:ShaderForge.SFN_Power,id:3302,x:32713,y:32350,varname:node_3302,prsc:2|VAL-2181-OUT,EXP-688-OUT;n:type:ShaderForge.SFN_ValueProperty,id:688,x:32547,y:32479,ptovrint:False,ptlb:Rim_pow,ptin:_Rim_pow,varname:node_688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_OneMinus,id:5703,x:32744,y:31954,varname:node_5703,prsc:2|IN-2181-OUT;n:type:ShaderForge.SFN_Power,id:9520,x:32937,y:32053,varname:node_9520,prsc:2|VAL-5703-OUT,EXP-5688-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5688,x:32744,y:32145,ptovrint:False,ptlb:Rim_pow2,ptin:_Rim_pow2,varname:node_5688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:7;n:type:ShaderForge.SFN_Multiply,id:8900,x:33163,y:32005,varname:node_8900,prsc:2|A-7839-RGB,B-9520-OUT;n:type:ShaderForge.SFN_Color,id:7839,x:32960,y:31849,ptovrint:False,ptlb:node_7839,ptin:_node_7839,varname:node_7839,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2dAsset,id:2368,x:31844,y:32491,ptovrint:False,ptlb:node_2368,ptin:_node_2368,varname:node_2368,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:043350eb21d42884984995acc56bbcea,ntxv:0,isnm:False;proporder:797-6649-6128-7688-7595-688-5688-7839-2368;pass:END;sub:END;*/

Shader "Shader Forge/01" {
    Properties {
        [HDR]_TintColor ("Color", Color) = (1,1,1,1)
        _time ("time", Float ) = 0.5
        _Time_2 ("Time_2", Float ) = 1
        _node_7688 ("node_7688", Float ) = 2
        _node_7595 ("node_7595", Color) = (1,1,1,1)
        _Rim_pow ("Rim_pow", Float ) = 2
        _Rim_pow2 ("Rim_pow2", Float ) = 7
        [HDR]_node_7839 ("node_7839", Color) = (1,1,1,1)
        _node_2368 ("node_2368", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _TintColor;
            uniform float _time;
            uniform float _Time_2;
            uniform float _node_7688;
            uniform float4 _node_7595;
            uniform float _Rim_pow;
            uniform float _Rim_pow2;
            uniform float4 _node_7839;
            uniform sampler2D _node_2368; uniform float4 _node_2368_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float node_2181 = (1.0-max(0,dot(normalDirection, viewDirection)));
                float4 node_5953 = _Time + _TimeEditor;
                float2 Time_1 = float2((0.5+i.uv0.r),(i.uv0.g+(node_5953.g*_time)));
                float2 node_7408 = Time_1;
                float4 _MainTex = tex2D(_node_2368,TRANSFORM_TEX(node_7408, _node_2368));
                float2 Time_2 = float2(i.uv0.r,(i.uv0.g+(node_5953.g*_Time_2)));
                float2 node_1240 = Time_2;
                float4 _MainTex_copy = tex2D(_node_2368,TRANSFORM_TEX(node_1240, _node_2368));
                float3 emissive = ((_node_7595.rgb*pow(node_2181,_Rim_pow))+(_MainTex.rgb*i.vertexColor.rgb*_TintColor.rgb*_node_7688*_MainTex_copy.rgb)+(_node_7839.rgb*pow((1.0 - node_2181),_Rim_pow2)));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(_MainTex.a*i.vertexColor.a*_TintColor.a));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
