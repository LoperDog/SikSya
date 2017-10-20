// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33564,y:34951,varname:node_3138,prsc:2|emission-5976-OUT,voffset-668-OUT;n:type:ShaderForge.SFN_Tex2d,id:1953,x:32155,y:34926,varname:node_1160,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6783-OUT,TEX-5943-TEX;n:type:ShaderForge.SFN_Tex2d,id:8730,x:32113,y:35290,varname:node_5553,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6522-OUT,TEX-5943-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:5943,x:31765,y:35163,ptovrint:False,ptlb:Noise_copy,ptin:_Noise_copy,varname:_Noise_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4283,x:32666,y:35162,varname:node_4283,prsc:2|A-1646-OUT,B-6231-OUT;n:type:ShaderForge.SFN_Multiply,id:5849,x:31355,y:35390,varname:node_5849,prsc:2|A-1921-T,B-4721-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4721,x:31093,y:35439,ptovrint:False,ptlb:Speed3,ptin:_Speed3,varname:_Speed3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.5;n:type:ShaderForge.SFN_Add,id:6602,x:31605,y:35372,varname:node_6602,prsc:2|A-3904-V,B-5849-OUT;n:type:ShaderForge.SFN_Append,id:6522,x:31839,y:35372,varname:node_6522,prsc:2|A-3904-U,B-6602-OUT;n:type:ShaderForge.SFN_Step,id:1646,x:32465,y:34985,varname:node_1646,prsc:2|A-1953-RGB,B-8681-OUT;n:type:ShaderForge.SFN_Vector1,id:8681,x:32188,y:35085,varname:node_8681,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Step,id:6231,x:32436,y:35247,varname:node_6231,prsc:2|A-8730-RGB,B-3396-OUT;n:type:ShaderForge.SFN_Vector1,id:3396,x:32143,y:35446,varname:node_3396,prsc:2,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:3904,x:30795,y:35231,varname:node_3904,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:1921,x:30818,y:35008,varname:node_1921,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2906,x:31351,y:35032,varname:node_2906,prsc:2|A-1921-T,B-2173-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2173,x:31109,y:35102,ptovrint:False,ptlb:Speed4,ptin:_Speed4,varname:_Speed4,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Add,id:2674,x:31597,y:35010,varname:node_2674,prsc:2|A-3904-V,B-2906-OUT;n:type:ShaderForge.SFN_Append,id:6783,x:31818,y:34955,varname:node_6783,prsc:2|A-4710-OUT,B-2674-OUT;n:type:ShaderForge.SFN_Color,id:4769,x:32764,y:34681,ptovrint:False,ptlb:node_4769,ptin:_node_4769,varname:node_4769,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9926471,c2:0.3452117,c3:0.1970696,c4:1;n:type:ShaderForge.SFN_Add,id:4710,x:31581,y:34878,varname:node_4710,prsc:2|A-1414-OUT,B-3904-U;n:type:ShaderForge.SFN_Vector1,id:1715,x:31041,y:34790,varname:node_1715,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:1414,x:31351,y:34862,varname:node_1414,prsc:2|A-1715-OUT,B-1921-T;n:type:ShaderForge.SFN_Multiply,id:6209,x:33137,y:34972,varname:node_6209,prsc:2|A-4769-RGB,B-4283-OUT;n:type:ShaderForge.SFN_OneMinus,id:2508,x:32931,y:35190,varname:node_2508,prsc:2|IN-4283-OUT;n:type:ShaderForge.SFN_Multiply,id:9050,x:33163,y:35190,varname:node_9050,prsc:2|A-2508-OUT,B-2894-RGB;n:type:ShaderForge.SFN_Color,id:2894,x:33105,y:35457,ptovrint:False,ptlb:node_2894,ptin:_node_2894,varname:node_2894,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2078431,c2:0.003921569,c3:0.003921569,c4:1;n:type:ShaderForge.SFN_Add,id:5976,x:33296,y:35093,varname:node_5976,prsc:2|A-6209-OUT,B-9050-OUT;n:type:ShaderForge.SFN_Multiply,id:668,x:32875,y:35411,varname:node_668,prsc:2|A-1953-RGB,B-3975-OUT,C-5370-OUT;n:type:ShaderForge.SFN_NormalVector,id:3975,x:32608,y:35350,prsc:2,pt:False;n:type:ShaderForge.SFN_ValueProperty,id:5370,x:32608,y:35549,ptovrint:False,ptlb:node_5370,ptin:_node_5370,varname:node_5370,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;proporder:5943-4721-2173-4769-2894-5370;pass:END;sub:END;*/

Shader "Shader Forge/q1" {
    Properties {
        _Noise_copy ("Noise_copy", 2D) = "white" {}
        _Speed3 ("Speed3", Float ) = 1.5
        _Speed4 ("Speed4", Float ) = 1
        _node_4769 ("node_4769", Color) = (0.9926471,0.3452117,0.1970696,1)
        _node_2894 ("node_2894", Color) = (0.2078431,0.003921569,0.003921569,1)
        _node_5370 ("node_5370", Float ) = 0.1
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
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Noise_copy; uniform float4 _Noise_copy_ST;
            uniform float _Speed3;
            uniform float _Speed4;
            uniform float4 _node_4769;
            uniform float4 _node_2894;
            uniform float _node_5370;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_1921 = _Time + _TimeEditor;
                float2 node_6783 = float2(((0.5*node_1921.g)+o.uv0.r),(o.uv0.g+(node_1921.g*_Speed4)));
                float4 node_1160 = tex2Dlod(_Noise_copy,float4(TRANSFORM_TEX(node_6783, _Noise_copy),0.0,0));
                v.vertex.xyz += (node_1160.rgb*v.normal*_node_5370);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 node_1921 = _Time + _TimeEditor;
                float2 node_6783 = float2(((0.5*node_1921.g)+i.uv0.r),(i.uv0.g+(node_1921.g*_Speed4)));
                float4 node_1160 = tex2D(_Noise_copy,TRANSFORM_TEX(node_6783, _Noise_copy));
                float2 node_6522 = float2(i.uv0.r,(i.uv0.g+(node_1921.g*_Speed3)));
                float4 node_5553 = tex2D(_Noise_copy,TRANSFORM_TEX(node_6522, _Noise_copy));
                float3 node_4283 = (step(node_1160.rgb,0.5)*step(node_5553.rgb,0.5));
                float3 emissive = ((_node_4769.rgb*node_4283)+((1.0 - node_4283)*_node_2894.rgb));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Noise_copy; uniform float4 _Noise_copy_ST;
            uniform float _Speed4;
            uniform float _node_5370;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_1921 = _Time + _TimeEditor;
                float2 node_6783 = float2(((0.5*node_1921.g)+o.uv0.r),(o.uv0.g+(node_1921.g*_Speed4)));
                float4 node_1160 = tex2Dlod(_Noise_copy,float4(TRANSFORM_TEX(node_6783, _Noise_copy),0.0,0));
                v.vertex.xyz += (node_1160.rgb*v.normal*_node_5370);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
