// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32505,y:32556,varname:node_2865,prsc:2|diff-7016-OUT,spec-9268-OUT,gloss-9745-OUT,normal-1738-OUT,emission-4890-OUT;n:type:ShaderForge.SFN_Multiply,id:6343,x:31571,y:31585,varname:node_6343,prsc:2|A-7846-RGB,B-6665-RGB;n:type:ShaderForge.SFN_Color,id:6665,x:31286,y:31659,ptovrint:False,ptlb:B_Color,ptin:_B_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:1813,x:33043,y:31745,ptovrint:False,ptlb:Gloss_1,ptin:_Gloss_1,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:6433,x:31700,y:32023,varname:node_6433,prsc:2|A-7327-OUT,B-7299-OUT;n:type:ShaderForge.SFN_Tex2d,id:7846,x:31286,y:31411,ptovrint:False,ptlb:Base,ptin:_Base,varname:node_7846,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1cc4d012632939e4fae174b1739fc8ec,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8764,x:33334,y:32841,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_8764,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:536daf0ea30ad064eacf7189b287cf6b,ntxv:3,isnm:True;n:type:ShaderForge.SFN_OneMinus,id:8154,x:31640,y:31827,varname:node_8154,prsc:2|IN-7327-OUT;n:type:ShaderForge.SFN_Multiply,id:8633,x:31891,y:31795,varname:node_8633,prsc:2|A-6343-OUT,B-8154-OUT;n:type:ShaderForge.SFN_Color,id:4801,x:31273,y:32222,ptovrint:False,ptlb:B_Color2,ptin:_B_Color2,varname:node_4801,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Add,id:3013,x:32125,y:31847,varname:node_3013,prsc:2|A-8633-OUT,B-6433-OUT;n:type:ShaderForge.SFN_Tex2d,id:6952,x:31273,y:32005,ptovrint:False,ptlb:Base_2,ptin:_Base_2,varname:node_6952,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e115182067afe5a4bab9b00fe0ed0180,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:7299,x:31508,y:32118,varname:node_7299,prsc:2|A-6952-RGB,B-4801-RGB;n:type:ShaderForge.SFN_Tex2d,id:8458,x:33357,y:33300,ptovrint:False,ptlb:Normal_2,ptin:_Normal_2,varname:node_8458,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:8096,x:33562,y:33233,varname:node_8096,prsc:2|A-2840-OUT,B-8458-RGB;n:type:ShaderForge.SFN_Multiply,id:6761,x:33588,y:32968,varname:node_6761,prsc:2|A-8764-RGB,B-4670-OUT;n:type:ShaderForge.SFN_OneMinus,id:4670,x:33334,y:33048,varname:node_4670,prsc:2|IN-2840-OUT;n:type:ShaderForge.SFN_Add,id:5800,x:33801,y:33049,varname:node_5800,prsc:2|A-6761-OUT,B-8096-OUT;n:type:ShaderForge.SFN_Get,id:2840,x:33037,y:33136,varname:node_2840,prsc:2|IN-8041-OUT;n:type:ShaderForge.SFN_Get,id:7327,x:31273,y:31902,varname:node_7327,prsc:2|IN-8041-OUT;n:type:ShaderForge.SFN_Get,id:7016,x:32010,y:32287,varname:node_7016,prsc:2|IN-8012-OUT;n:type:ShaderForge.SFN_Set,id:8012,x:32323,y:31941,varname:Base,prsc:2|IN-3013-OUT;n:type:ShaderForge.SFN_Get,id:276,x:33089,y:31996,varname:node_276,prsc:2|IN-8041-OUT;n:type:ShaderForge.SFN_OneMinus,id:2352,x:33500,y:31866,varname:node_2352,prsc:2|IN-276-OUT;n:type:ShaderForge.SFN_Multiply,id:8817,x:33566,y:32083,varname:node_8817,prsc:2|A-276-OUT,B-7211-OUT,C-8199-G;n:type:ShaderForge.SFN_Multiply,id:9977,x:33674,y:31767,varname:node_9977,prsc:2|A-1813-OUT,B-2352-OUT,C-186-R;n:type:ShaderForge.SFN_Add,id:6979,x:33884,y:31912,varname:node_6979,prsc:2|A-9977-OUT,B-8817-OUT;n:type:ShaderForge.SFN_Slider,id:7211,x:33111,y:32196,ptovrint:False,ptlb:Gloss_2,ptin:_Gloss_2,varname:node_7211,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Set,id:6871,x:34123,y:32029,varname:Gloss,prsc:2|IN-6979-OUT;n:type:ShaderForge.SFN_Get,id:9745,x:31957,y:32583,varname:node_9745,prsc:2|IN-6871-OUT;n:type:ShaderForge.SFN_Get,id:1738,x:31957,y:32651,varname:node_1738,prsc:2|IN-4756-OUT;n:type:ShaderForge.SFN_Set,id:4756,x:33992,y:33049,varname:Normal,prsc:2|IN-5800-OUT;n:type:ShaderForge.SFN_Tex2d,id:4704,x:31608,y:30999,ptovrint:False,ptlb:M,ptin:_M,varname:node_4704,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2dccf405580136841a90a4c8aa5c6e9b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Set,id:8041,x:32939,y:30894,varname:M,prsc:2|IN-7765-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:2892,x:31995,y:30791,ptovrint:False,ptlb:R,ptin:_R,varname:node_2892,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-8115-OUT,B-4704-R;n:type:ShaderForge.SFN_SwitchProperty,id:8114,x:31995,y:31128,ptovrint:False,ptlb:B,ptin:_B,varname:node_8114,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5147-OUT,B-4704-B;n:type:ShaderForge.SFN_SwitchProperty,id:7623,x:31995,y:31290,ptovrint:False,ptlb:A,ptin:_A,varname:node_7623,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5801-OUT,B-4704-A;n:type:ShaderForge.SFN_SwitchProperty,id:80,x:31995,y:30958,ptovrint:False,ptlb:G,ptin:_G,varname:node_80,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-9504-OUT,B-4704-G;n:type:ShaderForge.SFN_Vector1,id:8115,x:31780,y:30756,varname:node_8115,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:9504,x:31780,y:30923,varname:node_9504,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:5147,x:31780,y:31067,varname:node_5147,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:5801,x:31780,y:31270,varname:node_5801,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:8084,x:32295,y:30954,varname:node_8084,prsc:2|A-2892-OUT,B-80-OUT,C-8114-OUT,D-7623-OUT;n:type:ShaderForge.SFN_Slider,id:562,x:33004,y:30696,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:_Roug_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Get,id:6355,x:32984,y:31006,varname:node_6355,prsc:2|IN-8041-OUT;n:type:ShaderForge.SFN_OneMinus,id:1154,x:33395,y:30876,varname:node_1154,prsc:2|IN-6355-OUT;n:type:ShaderForge.SFN_Multiply,id:8625,x:33406,y:31075,varname:node_8625,prsc:2|A-6355-OUT,B-6257-OUT;n:type:ShaderForge.SFN_Multiply,id:6825,x:33557,y:30784,varname:node_6825,prsc:2|A-562-OUT,B-1154-OUT;n:type:ShaderForge.SFN_Add,id:9648,x:33779,y:30922,varname:node_9648,prsc:2|A-6825-OUT,B-8625-OUT;n:type:ShaderForge.SFN_Slider,id:6257,x:33007,y:31204,ptovrint:False,ptlb:Emission_2,ptin:_Emission_2,varname:_Roug_3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Set,id:4531,x:34001,y:30943,varname:Emission,prsc:2|IN-9648-OUT;n:type:ShaderForge.SFN_Get,id:4890,x:31957,y:32764,varname:node_4890,prsc:2|IN-4531-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:7765,x:32854,y:30939,ptovrint:False,ptlb:M_one Minus,ptin:_M_oneMinus,varname:_R_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-2515-OUT,B-6789-OUT;n:type:ShaderForge.SFN_OneMinus,id:6789,x:32654,y:31020,varname:node_6789,prsc:2|IN-2515-OUT;n:type:ShaderForge.SFN_Tex2d,id:186,x:33190,y:31463,ptovrint:False,ptlb:Gloss_map,ptin:_Gloss_map,varname:node_186,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b6e07415e1cb20541b8068b1bb484b0f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8199,x:33236,y:32302,ptovrint:False,ptlb:Gloss_map2,ptin:_Gloss_map2,varname:_node_186_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8a9be945761df0249877076ad46110b3,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:2458,x:32161,y:30723,ptovrint:False,ptlb:M_Alpha,ptin:_M_Alpha,varname:node_2458,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:2515,x:32468,y:30954,varname:node_2515,prsc:2|A-2458-OUT,B-8084-OUT;n:type:ShaderForge.SFN_Vector1,id:9268,x:31978,y:32449,varname:node_9268,prsc:2,v1:0;proporder:7846-6665-8764-186-1813-562-6952-4801-8458-8199-7211-6257-4704-2458-2892-80-8114-7623-7765;pass:END;sub:END;*/

Shader "Shader Forge/Tile" {
    Properties {
        _Base ("Base", 2D) = "white" {}
        _B_Color ("B_Color", Color) = (1,1,1,1)
        _Normal ("Normal", 2D) = "bump" {}
        _Gloss_map ("Gloss_map", 2D) = "white" {}
        _Gloss_1 ("Gloss_1", Range(0, 1)) = 0
        _Emission ("Emission", Range(0, 1)) = 0
        _Base_2 ("Base_2", 2D) = "white" {}
        _B_Color2 ("B_Color2", Color) = (1,1,1,1)
        _Normal_2 ("Normal_2", 2D) = "bump" {}
        _Gloss_map2 ("Gloss_map2", 2D) = "white" {}
        _Gloss_2 ("Gloss_2", Range(0, 1)) = 0
        _Emission_2 ("Emission_2", Range(0, 1)) = 0
        _M ("M", 2D) = "white" {}
        _M_Alpha ("M_Alpha", Range(0, 1)) = 1
        [MaterialToggle] _R ("R", Float ) = 0
        [MaterialToggle] _G ("G", Float ) = 0
        [MaterialToggle] _B ("B", Float ) = 0
        [MaterialToggle] _A ("A", Float ) = 0
        [MaterialToggle] _M_oneMinus ("M_one Minus", Float ) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _B_Color;
            uniform float _Gloss_1;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float4 _B_Color2;
            uniform sampler2D _Base_2; uniform float4 _Base_2_ST;
            uniform sampler2D _Normal_2; uniform float4 _Normal_2_ST;
            uniform float _Gloss_2;
            uniform sampler2D _M; uniform float4 _M_ST;
            uniform fixed _R;
            uniform fixed _B;
            uniform fixed _A;
            uniform fixed _G;
            uniform float _Emission;
            uniform float _Emission_2;
            uniform fixed _M_oneMinus;
            uniform sampler2D _Gloss_map; uniform float4 _Gloss_map_ST;
            uniform sampler2D _Gloss_map2; uniform float4 _Gloss_map2_ST;
            uniform float _M_Alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float4 _M_var = tex2D(_M,TRANSFORM_TEX(i.uv0, _M));
                float node_2515 = (_M_Alpha*(lerp( 0.0, _M_var.r, _R )+lerp( 0.0, _M_var.g, _G )+lerp( 0.0, _M_var.b, _B )+lerp( 0.0, _M_var.a, _A )));
                float M = lerp( node_2515, (1.0 - node_2515), _M_oneMinus );
                float node_2840 = M;
                float3 _Normal_2_var = UnpackNormal(tex2D(_Normal_2,TRANSFORM_TEX(i.uv0, _Normal_2)));
                float3 Normal = ((_Normal_var.rgb*(1.0 - node_2840))+(node_2840*_Normal_2_var.rgb));
                float3 normalLocal = Normal;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_276 = M;
                float4 _Gloss_map_var = tex2D(_Gloss_map,TRANSFORM_TEX(i.uv0, _Gloss_map));
                float4 _Gloss_map2_var = tex2D(_Gloss_map2,TRANSFORM_TEX(i.uv0, _Gloss_map2));
                float Gloss = ((_Gloss_1*(1.0 - node_276)*_Gloss_map_var.r)+(node_276*_Gloss_2*_Gloss_map2_var.g));
                float gloss = Gloss;
                float perceptualRoughness = 1.0 - Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float node_7327 = M;
                float4 _Base_2_var = tex2D(_Base_2,TRANSFORM_TEX(i.uv0, _Base_2));
                float3 Base = (((_Base_var.rgb*_B_Color.rgb)*(1.0 - node_7327))+(node_7327*(_Base_2_var.rgb*_B_Color2.rgb)));
                float3 diffuseColor = Base; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_6355 = M;
                float Emission = ((_Emission*(1.0 - node_6355))+(node_6355*_Emission_2));
                float node_4890 = Emission;
                float3 emissive = float3(node_4890,node_4890,node_4890);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _B_Color;
            uniform float _Gloss_1;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float4 _B_Color2;
            uniform sampler2D _Base_2; uniform float4 _Base_2_ST;
            uniform sampler2D _Normal_2; uniform float4 _Normal_2_ST;
            uniform float _Gloss_2;
            uniform sampler2D _M; uniform float4 _M_ST;
            uniform fixed _R;
            uniform fixed _B;
            uniform fixed _A;
            uniform fixed _G;
            uniform float _Emission;
            uniform float _Emission_2;
            uniform fixed _M_oneMinus;
            uniform sampler2D _Gloss_map; uniform float4 _Gloss_map_ST;
            uniform sampler2D _Gloss_map2; uniform float4 _Gloss_map2_ST;
            uniform float _M_Alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float4 _M_var = tex2D(_M,TRANSFORM_TEX(i.uv0, _M));
                float node_2515 = (_M_Alpha*(lerp( 0.0, _M_var.r, _R )+lerp( 0.0, _M_var.g, _G )+lerp( 0.0, _M_var.b, _B )+lerp( 0.0, _M_var.a, _A )));
                float M = lerp( node_2515, (1.0 - node_2515), _M_oneMinus );
                float node_2840 = M;
                float3 _Normal_2_var = UnpackNormal(tex2D(_Normal_2,TRANSFORM_TEX(i.uv0, _Normal_2)));
                float3 Normal = ((_Normal_var.rgb*(1.0 - node_2840))+(node_2840*_Normal_2_var.rgb));
                float3 normalLocal = Normal;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_276 = M;
                float4 _Gloss_map_var = tex2D(_Gloss_map,TRANSFORM_TEX(i.uv0, _Gloss_map));
                float4 _Gloss_map2_var = tex2D(_Gloss_map2,TRANSFORM_TEX(i.uv0, _Gloss_map2));
                float Gloss = ((_Gloss_1*(1.0 - node_276)*_Gloss_map_var.r)+(node_276*_Gloss_2*_Gloss_map2_var.g));
                float gloss = Gloss;
                float perceptualRoughness = 1.0 - Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float node_7327 = M;
                float4 _Base_2_var = tex2D(_Base_2,TRANSFORM_TEX(i.uv0, _Base_2));
                float3 Base = (((_Base_var.rgb*_B_Color.rgb)*(1.0 - node_7327))+(node_7327*(_Base_2_var.rgb*_B_Color2.rgb)));
                float3 diffuseColor = Base; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _B_Color;
            uniform float _Gloss_1;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform float4 _B_Color2;
            uniform sampler2D _Base_2; uniform float4 _Base_2_ST;
            uniform float _Gloss_2;
            uniform sampler2D _M; uniform float4 _M_ST;
            uniform fixed _R;
            uniform fixed _B;
            uniform fixed _A;
            uniform fixed _G;
            uniform float _Emission;
            uniform float _Emission_2;
            uniform fixed _M_oneMinus;
            uniform sampler2D _Gloss_map; uniform float4 _Gloss_map_ST;
            uniform sampler2D _Gloss_map2; uniform float4 _Gloss_map2_ST;
            uniform float _M_Alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _M_var = tex2D(_M,TRANSFORM_TEX(i.uv0, _M));
                float node_2515 = (_M_Alpha*(lerp( 0.0, _M_var.r, _R )+lerp( 0.0, _M_var.g, _G )+lerp( 0.0, _M_var.b, _B )+lerp( 0.0, _M_var.a, _A )));
                float M = lerp( node_2515, (1.0 - node_2515), _M_oneMinus );
                float node_6355 = M;
                float Emission = ((_Emission*(1.0 - node_6355))+(node_6355*_Emission_2));
                float node_4890 = Emission;
                o.Emission = float3(node_4890,node_4890,node_4890);
                
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float node_7327 = M;
                float4 _Base_2_var = tex2D(_Base_2,TRANSFORM_TEX(i.uv0, _Base_2));
                float3 Base = (((_Base_var.rgb*_B_Color.rgb)*(1.0 - node_7327))+(node_7327*(_Base_2_var.rgb*_B_Color2.rgb)));
                float3 diffColor = Base;
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0.0, specColor, specularMonochrome );
                float node_276 = M;
                float4 _Gloss_map_var = tex2D(_Gloss_map,TRANSFORM_TEX(i.uv0, _Gloss_map));
                float4 _Gloss_map2_var = tex2D(_Gloss_map2,TRANSFORM_TEX(i.uv0, _Gloss_map2));
                float Gloss = ((_Gloss_1*(1.0 - node_276)*_Gloss_map_var.r)+(node_276*_Gloss_2*_Gloss_map2_var.g));
                float roughness = 1.0 - Gloss;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
