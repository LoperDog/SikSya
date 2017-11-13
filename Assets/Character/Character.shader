// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.7058823,fgcg:0.8539554,fgcb:1,fgca:1,fgde:0.0038,fgrn:0,fgrf:500,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:35662,y:32817,varname:node_2865,prsc:2|diff-6343-OUT,spec-358-OUT,gloss-1813-OUT,normal-2011-RGB,emission-4635-OUT,clip-355-OUT;n:type:ShaderForge.SFN_Multiply,id:6343,x:34574,y:32050,varname:node_6343,prsc:2|A-9059-RGB,B-6665-RGB;n:type:ShaderForge.SFN_Color,id:6665,x:34322,y:32090,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:358,x:34236,y:32409,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:1813,x:34236,y:32531,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Fresnel,id:8040,x:32977,y:33130,varname:node_8040,prsc:2;n:type:ShaderForge.SFN_OneMinus,id:4155,x:33234,y:33257,varname:node_4155,prsc:2|IN-8040-OUT;n:type:ShaderForge.SFN_Power,id:7184,x:33458,y:33007,varname:node_7184,prsc:2|VAL-8040-OUT,EXP-3267-OUT;n:type:ShaderForge.SFN_Power,id:8160,x:33524,y:33165,varname:node_8160,prsc:2|VAL-4155-OUT,EXP-2082-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3267,x:33278,y:33044,ptovrint:False,ptlb:Rim_Pow,ptin:_Rim_Pow,varname:node_3267,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:2082,x:33311,y:33410,ptovrint:False,ptlb:1-Rim_Pow,ptin:_1Rim_Pow,varname:node_2082,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:1765,x:33725,y:32954,varname:node_1765,prsc:2|A-8456-RGB,B-7184-OUT,C-8707-OUT;n:type:ShaderForge.SFN_Multiply,id:4236,x:33736,y:33225,varname:node_4236,prsc:2|A-8160-OUT,B-3890-RGB,C-1732-OUT;n:type:ShaderForge.SFN_Color,id:8456,x:33562,y:32754,ptovrint:False,ptlb:Rim_Color,ptin:_Rim_Color,varname:node_8456,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:3890,x:33513,y:33332,ptovrint:False,ptlb:1-Rim_Color,ptin:_1Rim_Color,varname:node_3890,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Add,id:1643,x:34194,y:33053,varname:node_1643,prsc:2|A-7876-OUT,B-7289-OUT;n:type:ShaderForge.SFN_Clamp01,id:8168,x:34385,y:33053,varname:node_8168,prsc:2|IN-1643-OUT;n:type:ShaderForge.SFN_Slider,id:8707,x:33301,y:32912,ptovrint:False,ptlb:Rim,ptin:_Rim,varname:node_8707,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2457656,max:1;n:type:ShaderForge.SFN_Slider,id:1732,x:33356,y:33527,ptovrint:False,ptlb:1-Rim,ptin:_1Rim,varname:node_1732,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3606181,max:1;n:type:ShaderForge.SFN_SwitchProperty,id:7876,x:34006,y:32854,ptovrint:False,ptlb:Rim_On,ptin:_Rim_On,varname:node_7876,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-9493-OUT,B-1765-OUT;n:type:ShaderForge.SFN_Vector1,id:9493,x:33804,y:32767,varname:node_9493,prsc:2,v1:0;n:type:ShaderForge.SFN_SwitchProperty,id:7289,x:33984,y:33191,ptovrint:False,ptlb:1-Rim_On,ptin:_1Rim_On,varname:node_7289,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-9493-OUT,B-4236-OUT;n:type:ShaderForge.SFN_Tex2d,id:2011,x:34632,y:32513,ptovrint:False,ptlb:N,ptin:_N,varname:node_2011,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ca3f7cb13a412a14a82681205e74031f,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:9059,x:34322,y:31909,ptovrint:False,ptlb:Base,ptin:_Base,varname:node_9059,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4f41d25cac94f4642b3e531ff1f7fc81,ntxv:0,isnm:False;n:type:ShaderForge.SFN_SwitchProperty,id:355,x:35291,y:33097,ptovrint:False,ptlb:death,ptin:_death,varname:node_355,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-2378-OUT,B-7608-OUT;n:type:ShaderForge.SFN_Vector1,id:2378,x:35140,y:33070,varname:node_2378,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:7608,x:35140,y:33156,varname:node_7608,prsc:2,v1:0;n:type:ShaderForge.SFN_Set,id:9118,x:34576,y:33053,varname:Rim,prsc:2|IN-8168-OUT;n:type:ShaderForge.SFN_Get,id:5892,x:34570,y:32663,varname:node_5892,prsc:2|IN-9118-OUT;n:type:ShaderForge.SFN_Time,id:8210,x:33919,y:33666,varname:node_8210,prsc:2;n:type:ShaderForge.SFN_Set,id:693,x:35064,y:33558,varname:shield,prsc:2|IN-487-OUT;n:type:ShaderForge.SFN_Get,id:3798,x:34570,y:32731,varname:node_3798,prsc:2|IN-693-OUT;n:type:ShaderForge.SFN_Lerp,id:4023,x:34844,y:32824,varname:node_4023,prsc:2|A-5892-OUT,B-3798-OUT,T-8991-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:4635,x:35063,y:32799,ptovrint:False,ptlb:shield,ptin:_shield,varname:node_4635,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5892-OUT,B-4023-OUT;n:type:ShaderForge.SFN_Vector1,id:8991,x:34578,y:32806,varname:node_8991,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Lerp,id:487,x:34846,y:33503,varname:node_487,prsc:2|A-7702-OUT,B-1388-RGB,T-4323-OUT;n:type:ShaderForge.SFN_Color,id:1388,x:34517,y:33494,ptovrint:False,ptlb:shield_Color,ptin:_shield_Color,varname:node_1388,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Sin,id:4246,x:34347,y:33688,varname:node_4246,prsc:2|IN-2032-OUT;n:type:ShaderForge.SFN_Multiply,id:5296,x:34544,y:33731,varname:node_5296,prsc:2|A-4246-OUT,B-3200-OUT;n:type:ShaderForge.SFN_Add,id:4323,x:34706,y:33708,varname:node_4323,prsc:2|A-5296-OUT,B-3200-OUT;n:type:ShaderForge.SFN_Vector1,id:3200,x:34372,y:33825,varname:node_3200,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:2032,x:34169,y:33688,varname:node_2032,prsc:2|A-8210-T,B-7464-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7464,x:33919,y:33846,ptovrint:False,ptlb:Time1,ptin:_Time1,varname:node_7464,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Vector1,id:7702,x:34517,y:33373,varname:node_7702,prsc:2,v1:0;proporder:6665-358-1813-8456-3267-8707-3890-2082-1732-7876-7289-2011-9059-355-4635-1388-7464;pass:END;sub:END;*/

Shader "Shader Forge/C" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Gloss ("Gloss", Range(0, 1)) = 0
        _Rim_Color ("Rim_Color", Color) = (1,1,1,1)
        _Rim_Pow ("Rim_Pow", Float ) = 1
        _Rim ("Rim", Range(0, 1)) = 0.2457656
        _1Rim_Color ("1-Rim_Color", Color) = (1,1,1,1)
        _1Rim_Pow ("1-Rim_Pow", Float ) = 1
        _1Rim ("1-Rim", Range(0, 1)) = 0.3606181
        [MaterialToggle] _Rim_On ("Rim_On", Float ) = 0
        [MaterialToggle] _1Rim_On ("1-Rim_On", Float ) = 0.3606181
        _N ("N", 2D) = "bump" {}
        _Base ("Base", 2D) = "white" {}
        [MaterialToggle] _death ("death", Float ) = 1
        [MaterialToggle] _shield ("shield", Float ) = 0.3606181
        _shield_Color ("shield_Color", Color) = (0.5,0.5,0.5,1)
        _Time1 ("Time1", Float ) = 10
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
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
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _Rim_Pow;
            uniform float _1Rim_Pow;
            uniform float4 _Rim_Color;
            uniform float4 _1Rim_Color;
            uniform float _Rim;
            uniform float _1Rim;
            uniform fixed _Rim_On;
            uniform fixed _1Rim_On;
            uniform sampler2D _N; uniform float4 _N_ST;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform fixed _death;
            uniform fixed _shield;
            uniform float4 _shield_Color;
            uniform float _Time1;
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
                float3 _N_var = UnpackNormal(tex2D(_N,TRANSFORM_TEX(i.uv0, _N)));
                float3 normalLocal = _N_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                clip(lerp( 1.0, 0.0, _death ) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
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
                float3 specularColor = _Metallic;
                float specularMonochrome;
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float3 diffuseColor = (_Base_var.rgb*_Color.rgb); // Need this for specular when using metallic
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
                float node_9493 = 0.0;
                float node_8040 = (1.0-max(0,dot(normalDirection, viewDirection)));
                float3 Rim = saturate((lerp( node_9493, (_Rim_Color.rgb*pow(node_8040,_Rim_Pow)*_Rim), _Rim_On )+lerp( node_9493, (pow((1.0 - node_8040),_1Rim_Pow)*_1Rim_Color.rgb*_1Rim), _1Rim_On )));
                float3 node_5892 = Rim;
                float node_7702 = 0.0;
                float4 node_8210 = _Time + _TimeEditor;
                float node_3200 = 0.5;
                float3 shield = lerp(float3(node_7702,node_7702,node_7702),_shield_Color.rgb,((sin((node_8210.g*_Time1))*node_3200)+node_3200));
                float3 emissive = lerp( node_5892, lerp(node_5892,shield,0.3), _shield );
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
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _Rim_Pow;
            uniform float _1Rim_Pow;
            uniform float4 _Rim_Color;
            uniform float4 _1Rim_Color;
            uniform float _Rim;
            uniform float _1Rim;
            uniform fixed _Rim_On;
            uniform fixed _1Rim_On;
            uniform sampler2D _N; uniform float4 _N_ST;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform fixed _death;
            uniform fixed _shield;
            uniform float4 _shield_Color;
            uniform float _Time1;
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
                float3 _N_var = UnpackNormal(tex2D(_N,TRANSFORM_TEX(i.uv0, _N)));
                float3 normalLocal = _N_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                clip(lerp( 1.0, 0.0, _death ) - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = _Metallic;
                float specularMonochrome;
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float3 diffuseColor = (_Base_var.rgb*_Color.rgb); // Need this for specular when using metallic
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform fixed _death;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                clip(lerp( 1.0, 0.0, _death ) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
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
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _Rim_Pow;
            uniform float _1Rim_Pow;
            uniform float4 _Rim_Color;
            uniform float4 _1Rim_Color;
            uniform float _Rim;
            uniform float _1Rim;
            uniform fixed _Rim_On;
            uniform fixed _1Rim_On;
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform fixed _shield;
            uniform float4 _shield_Color;
            uniform float _Time1;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float node_9493 = 0.0;
                float node_8040 = (1.0-max(0,dot(normalDirection, viewDirection)));
                float3 Rim = saturate((lerp( node_9493, (_Rim_Color.rgb*pow(node_8040,_Rim_Pow)*_Rim), _Rim_On )+lerp( node_9493, (pow((1.0 - node_8040),_1Rim_Pow)*_1Rim_Color.rgb*_1Rim), _1Rim_On )));
                float3 node_5892 = Rim;
                float node_7702 = 0.0;
                float4 node_8210 = _Time + _TimeEditor;
                float node_3200 = 0.5;
                float3 shield = lerp(float3(node_7702,node_7702,node_7702),_shield_Color.rgb,((sin((node_8210.g*_Time1))*node_3200)+node_3200));
                o.Emission = lerp( node_5892, lerp(node_5892,shield,0.3), _shield );
                
                float4 _Base_var = tex2D(_Base,TRANSFORM_TEX(i.uv0, _Base));
                float3 diffColor = (_Base_var.rgb*_Color.rgb);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, _Metallic, specColor, specularMonochrome );
                float roughness = 1.0 - _Gloss;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}