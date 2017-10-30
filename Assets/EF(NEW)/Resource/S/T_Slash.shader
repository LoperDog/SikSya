// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:34181,y:31977,varname:node_4795,prsc:2|emission-8529-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32715,y:32147,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f8aa200846b7f034781de58bf4d8b7ea,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Color,id:797,x:33601,y:32223,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8308824,c2:0.719143,c3:0.3543469,c4:1;n:type:ShaderForge.SFN_Append,id:4084,x:33422,y:31940,varname:node_4084,prsc:2|A-8237-OUT,B-5990-OUT;n:type:ShaderForge.SFN_Vector1,id:5990,x:33251,y:32099,varname:node_5990,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2dAsset,id:6481,x:33435,y:32099,ptovrint:False,ptlb:node_6481,ptin:_node_6481,varname:node_6481,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5635,x:33638,y:31940,varname:node_5635,prsc:2,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False|UVIN-4084-OUT,TEX-6481-TEX;n:type:ShaderForge.SFN_Slider,id:6893,x:32211,y:31940,ptovrint:False,ptlb:node_6893,ptin:_node_6893,varname:node_6893,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_OneMinus,id:6892,x:32552,y:31940,varname:node_6892,prsc:2|IN-6893-OUT;n:type:ShaderForge.SFN_RemapRange,id:9658,x:32715,y:31940,varname:node_9658,prsc:2,frmn:0,frmx:1,tomn:-0.5,tomx:0.5|IN-6892-OUT;n:type:ShaderForge.SFN_Add,id:6027,x:32898,y:31940,varname:node_6027,prsc:2|A-9658-OUT,B-6074-A;n:type:ShaderForge.SFN_RemapRange,id:7314,x:33077,y:31940,varname:node_7314,prsc:2,frmn:0,frmx:1,tomn:-0.5,tomx:0.5|IN-6027-OUT;n:type:ShaderForge.SFN_Clamp01,id:8237,x:33237,y:31940,varname:node_8237,prsc:2|IN-7314-OUT;n:type:ShaderForge.SFN_Multiply,id:8529,x:33955,y:31937,varname:node_8529,prsc:2|A-5635-RGB,B-797-RGB;n:type:ShaderForge.SFN_Add,id:5989,x:33933,y:32174,varname:node_5989,prsc:2;proporder:797-6481-6893-6074;pass:END;sub:END;*/

Shader "Shader Forge/ab" {
    Properties {
        [HDR]_TintColor ("Color", Color) = (0.8308824,0.719143,0.3543469,1)
        _node_6481 ("node_6481", 2D) = "white" {}
        _node_6893 ("node_6893", Range(0, 1)) = 0
        _MainTex ("MainTex", 2D) = "bump" {}
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
            Blend One One
            Cull Off
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
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform sampler2D _node_6481; uniform float4 _node_6481_ST;
            uniform float _node_6893;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float2 node_4084 = float2(saturate(((((1.0 - _node_6893)*1.0+-0.5)+_MainTex_var.a)*1.0+-0.5)),0.0);
                float4 node_5635 = tex2D(_node_6481,TRANSFORM_TEX(node_4084, _node_6481));
                float3 emissive = (node_5635.rgb*_TintColor.rgb);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
