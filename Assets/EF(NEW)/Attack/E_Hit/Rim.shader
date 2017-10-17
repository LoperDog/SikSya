// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.07369161,fgcg:0.1035251,fgcb:0.2132353,fgca:1,fgde:0.01,fgrn:0,fgrf:500,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:32716,y:32678,varname:node_4795,prsc:2|emission-1615-OUT;n:type:ShaderForge.SFN_Color,id:8552,x:31867,y:32661,ptovrint:False,ptlb:node_8552,ptin:_node_8552,varname:node_8552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_NormalVector,id:4508,x:31492,y:33004,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:4938,x:31714,y:32931,varname:node_4938,prsc:2,dt:0|A-8036-OUT,B-4508-OUT;n:type:ShaderForge.SFN_Power,id:7341,x:31867,y:32962,varname:node_7341,prsc:2|VAL-4938-OUT,EXP-1980-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1980,x:31697,y:33095,ptovrint:False,ptlb:node_1980,ptin:_node_1980,varname:node_1980,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Lerp,id:1615,x:32077,y:32791,varname:node_1615,prsc:2|A-8552-RGB,B-3843-RGB,T-7341-OUT;n:type:ShaderForge.SFN_Color,id:3843,x:31867,y:32824,ptovrint:False,ptlb:node_8552_copy,ptin:_node_8552_copy,varname:_node_8552_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.9091278,c3:0.7941176,c4:1;n:type:ShaderForge.SFN_TexCoord,id:458,x:31347,y:33067,varname:node_458,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ViewVector,id:8036,x:31492,y:32848,varname:node_8036,prsc:2;proporder:8552-1980-3843;pass:END;sub:END;*/

Shader "Shader Forge/q1" {
    Properties {
        _node_8552 ("node_8552", Color) = (1,0,0,1)
        _node_1980 ("node_1980", Float ) = 2
        _node_8552_copy ("node_8552_copy", Color) = (1,0.9091278,0.7941176,1)
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
            uniform float4 _node_8552;
            uniform float _node_1980;
            uniform float4 _node_8552_copy;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
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
                float3 emissive = lerp(_node_8552.rgb,_node_8552_copy.rgb,pow(dot(viewDirection,i.normalDir),_node_1980));
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
