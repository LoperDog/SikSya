// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.07369161,fgcg:0.1035251,fgcb:0.2132353,fgca:1,fgde:0.01,fgrn:0,fgrf:500,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33679,y:32454,varname:node_2865,prsc:2|diff-9942-OUT,spec-2293-OUT,gloss-5896-OUT,amdfl-6171-OUT;n:type:ShaderForge.SFN_Tex2d,id:8160,x:31686,y:32657,varname:node_8160,prsc:2,tex:dd9f73c1bf91fdf4fadb4ba010662cae,ntxv:0,isnm:False|TEX-2776-TEX;n:type:ShaderForge.SFN_Tex2d,id:9960,x:31580,y:33003,ptovrint:False,ptlb:IdMap,ptin:_IdMap,varname:node_9960,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:180f00834d6a2914f84d907793d72c6b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:2776,x:31336,y:32682,ptovrint:False,ptlb:Main,ptin:_Main,varname:node_2776,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd9f73c1bf91fdf4fadb4ba010662cae,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7174,x:32352,y:33354,varname:node_7174,prsc:2|A-5980-OUT,B-8072-OUT,T-9960-G;n:type:ShaderForge.SFN_ValueProperty,id:4158,x:32149,y:33269,ptovrint:False,ptlb:GL_A,ptin:_GL_A,varname:node_4158,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8072,x:32149,y:33371,ptovrint:False,ptlb:GL_B,ptin:_GL_B,varname:node_8072,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:5980,x:32352,y:33210,varname:node_5980,prsc:2|A-7016-OUT,B-4158-OUT,T-9960-R;n:type:ShaderForge.SFN_Lerp,id:9414,x:32364,y:33494,varname:node_9414,prsc:2|A-7174-OUT,B-8556-OUT,T-9960-B;n:type:ShaderForge.SFN_Lerp,id:5896,x:32364,y:33610,varname:node_5896,prsc:2|A-9414-OUT,B-520-OUT,T-8160-A;n:type:ShaderForge.SFN_ValueProperty,id:8556,x:32149,y:33528,ptovrint:False,ptlb:GL_C,ptin:_GL_C,varname:node_8556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:520,x:32149,y:33644,ptovrint:False,ptlb:GL_D,ptin:_GL_D,varname:node_520,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:7016,x:32165,y:33182,varname:node_7016,prsc:2,v1:0;n:type:ShaderForge.SFN_Lerp,id:5779,x:32765,y:33367,varname:node_5779,prsc:2|A-5448-OUT,B-4396-OUT,T-9960-G;n:type:ShaderForge.SFN_ValueProperty,id:9814,x:32562,y:33282,ptovrint:False,ptlb:SP_A,ptin:_SP_A,varname:_a_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4396,x:32562,y:33384,ptovrint:False,ptlb:SP_B,ptin:_SP_B,varname:_b_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:5448,x:32765,y:33223,varname:node_5448,prsc:2|A-785-OUT,B-9814-OUT,T-9960-R;n:type:ShaderForge.SFN_Lerp,id:9349,x:32777,y:33507,varname:node_9349,prsc:2|A-5779-OUT,B-1563-OUT,T-9960-B;n:type:ShaderForge.SFN_Lerp,id:2293,x:32777,y:33623,varname:node_2293,prsc:2|A-9349-OUT,B-7533-OUT,T-8160-A;n:type:ShaderForge.SFN_ValueProperty,id:1563,x:32562,y:33541,ptovrint:False,ptlb:SP_C,ptin:_SP_C,varname:_c_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:7533,x:32562,y:33657,ptovrint:False,ptlb:SP_D,ptin:_SP_D,varname:_d_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:785,x:32578,y:33195,varname:node_785,prsc:2,v1:0;n:type:ShaderForge.SFN_Color,id:7324,x:31922,y:31894,ptovrint:False,ptlb:Color_A,ptin:_Color_A,varname:node_7324,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:3449,x:31938,y:32103,ptovrint:False,ptlb:Color_B,ptin:_Color_B,varname:_node_7324_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:7522,x:32242,y:32028,varname:node_7522,prsc:2|A-9960-R,B-7324-RGB;n:type:ShaderForge.SFN_Multiply,id:5320,x:32242,y:32156,varname:node_5320,prsc:2|A-9960-G,B-3449-RGB;n:type:ShaderForge.SFN_Add,id:6641,x:32482,y:32104,varname:node_6641,prsc:2|A-7522-OUT,B-5320-OUT;n:type:ShaderForge.SFN_Multiply,id:7700,x:32266,y:32311,varname:node_7700,prsc:2|A-9960-B,B-7080-RGB;n:type:ShaderForge.SFN_Add,id:1068,x:32682,y:32224,varname:node_1068,prsc:2|A-6641-OUT,B-4000-OUT;n:type:ShaderForge.SFN_Multiply,id:5977,x:32247,y:32489,varname:node_5977,prsc:2|A-8160-A,B-2567-RGB;n:type:ShaderForge.SFN_Color,id:2567,x:31940,y:32476,ptovrint:False,ptlb:Color_D,ptin:_Color_D,varname:node_2567,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Add,id:4000,x:32499,y:32397,varname:node_4000,prsc:2|A-7700-OUT,B-5977-OUT;n:type:ShaderForge.SFN_Color,id:7080,x:31940,y:32297,ptovrint:False,ptlb:Color_C,ptin:_Color_C,varname:node_7080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:724,x:32916,y:32369,varname:node_724,prsc:2|A-1068-OUT,B-8160-RGB;n:type:ShaderForge.SFN_NormalVector,id:3810,x:32943,y:31903,prsc:2,pt:False;n:type:ShaderForge.SFN_ViewVector,id:9072,x:32956,y:31723,varname:node_9072,prsc:2;n:type:ShaderForge.SFN_Dot,id:1050,x:33156,y:31803,varname:node_1050,prsc:2,dt:0|A-9072-OUT,B-3810-OUT;n:type:ShaderForge.SFN_Power,id:1233,x:33363,y:31907,varname:node_1233,prsc:2|VAL-1050-OUT,EXP-5894-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5894,x:33156,y:32007,ptovrint:False,ptlb:Rim_Pow1,ptin:_Rim_Pow1,varname:node_5894,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:1791,x:33795,y:31926,varname:node_1791,prsc:2|A-3170-RGB,B-7816-OUT;n:type:ShaderForge.SFN_Color,id:3170,x:33582,y:31800,ptovrint:False,ptlb:Rim_Color,ptin:_Rim_Color,varname:node_3170,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_OneMinus,id:7816,x:33569,y:31962,varname:node_7816,prsc:2|IN-1233-OUT;n:type:ShaderForge.SFN_Add,id:9942,x:33459,y:32293,varname:node_9942,prsc:2|A-1791-OUT,B-724-OUT;n:type:ShaderForge.SFN_Multiply,id:6171,x:33419,y:32670,varname:node_6171,prsc:2|A-9923-OUT,B-8160-A;n:type:ShaderForge.SFN_ValueProperty,id:9923,x:33221,y:32639,ptovrint:False,ptlb:Diffuse Light,ptin:_DiffuseLight,varname:node_9923,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;proporder:9960-2776-4158-9814-8072-4396-8556-1563-520-7533-7324-3449-7080-2567-5894-3170-9923;pass:END;sub:END;*/

Shader "Shader Forge/rim" {
    Properties {
        _IdMap ("IdMap", 2D) = "white" {}
        _Main ("Main", 2D) = "white" {}
        _GL_A ("GL_A", Float ) = 0
        _SP_A ("SP_A", Float ) = 0
        _GL_B ("GL_B", Float ) = 0
        _SP_B ("SP_B", Float ) = 0
        _GL_C ("GL_C", Float ) = 0
        _SP_C ("SP_C", Float ) = 0
        _GL_D ("GL_D", Float ) = 0
        _SP_D ("SP_D", Float ) = 0
        _Color_A ("Color_A", Color) = (1,1,1,1)
        _Color_B ("Color_B", Color) = (1,1,1,1)
        _Color_C ("Color_C", Color) = (1,1,1,1)
        _Color_D ("Color_D", Color) = (1,1,1,1)
        _Rim_Pow1 ("Rim_Pow1", Float ) = 0.1
        _Rim_Color ("Rim_Color", Color) = (1,1,1,1)
        _DiffuseLight ("Diffuse Light", Float ) = 0.5
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
            uniform sampler2D _IdMap; uniform float4 _IdMap_ST;
            uniform sampler2D _Main; uniform float4 _Main_ST;
            uniform float _GL_A;
            uniform float _GL_B;
            uniform float _GL_C;
            uniform float _GL_D;
            uniform float _SP_A;
            uniform float _SP_B;
            uniform float _SP_C;
            uniform float _SP_D;
            uniform float4 _Color_A;
            uniform float4 _Color_B;
            uniform float4 _Color_D;
            uniform float4 _Color_C;
            uniform float _Rim_Pow1;
            uniform float4 _Rim_Color;
            uniform float _DiffuseLight;
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
                float3 normalDirection = i.normalDir;
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
                float4 _IdMap_var = tex2D(_IdMap,TRANSFORM_TEX(i.uv0, _IdMap));
                float4 node_8160 = tex2D(_Main,TRANSFORM_TEX(i.uv0, _Main));
                float gloss = lerp(lerp(lerp(lerp(0.0,_GL_A,_IdMap_var.r),_GL_B,_IdMap_var.g),_GL_C,_IdMap_var.b),_GL_D,node_8160.a);
                float perceptualRoughness = 1.0 - lerp(lerp(lerp(lerp(0.0,_GL_A,_IdMap_var.r),_GL_B,_IdMap_var.g),_GL_C,_IdMap_var.b),_GL_D,node_8160.a);
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
                float node_2293 = lerp(lerp(lerp(lerp(0.0,_SP_A,_IdMap_var.r),_SP_B,_IdMap_var.g),_SP_C,_IdMap_var.b),_SP_D,node_8160.a);
                float3 specularColor = float3(node_2293,node_2293,node_2293);
                float specularMonochrome;
                float node_1050 = dot(viewDirection,i.normalDir);
                float3 node_724 = ((((_IdMap_var.r*_Color_A.rgb)+(_IdMap_var.g*_Color_B.rgb))+((_IdMap_var.b*_Color_C.rgb)+(node_8160.a*_Color_D.rgb)))*node_8160.rgb);
                float3 diffuseColor = ((_Rim_Color.rgb*(1.0 - pow(node_1050,_Rim_Pow1)))+node_724); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
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
                float node_6171 = (_DiffuseLight*node_8160.a);
                indirectDiffuse += float3(node_6171,node_6171,node_6171); // Diffuse Ambient Light
                indirectDiffuse += gi.indirect.diffuse;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
            uniform sampler2D _IdMap; uniform float4 _IdMap_ST;
            uniform sampler2D _Main; uniform float4 _Main_ST;
            uniform float _GL_A;
            uniform float _GL_B;
            uniform float _GL_C;
            uniform float _GL_D;
            uniform float _SP_A;
            uniform float _SP_B;
            uniform float _SP_C;
            uniform float _SP_D;
            uniform float4 _Color_A;
            uniform float4 _Color_B;
            uniform float4 _Color_D;
            uniform float4 _Color_C;
            uniform float _Rim_Pow1;
            uniform float4 _Rim_Color;
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
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _IdMap_var = tex2D(_IdMap,TRANSFORM_TEX(i.uv0, _IdMap));
                float4 node_8160 = tex2D(_Main,TRANSFORM_TEX(i.uv0, _Main));
                float gloss = lerp(lerp(lerp(lerp(0.0,_GL_A,_IdMap_var.r),_GL_B,_IdMap_var.g),_GL_C,_IdMap_var.b),_GL_D,node_8160.a);
                float perceptualRoughness = 1.0 - lerp(lerp(lerp(lerp(0.0,_GL_A,_IdMap_var.r),_GL_B,_IdMap_var.g),_GL_C,_IdMap_var.b),_GL_D,node_8160.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_2293 = lerp(lerp(lerp(lerp(0.0,_SP_A,_IdMap_var.r),_SP_B,_IdMap_var.g),_SP_C,_IdMap_var.b),_SP_D,node_8160.a);
                float3 specularColor = float3(node_2293,node_2293,node_2293);
                float specularMonochrome;
                float node_1050 = dot(viewDirection,i.normalDir);
                float3 node_724 = ((((_IdMap_var.r*_Color_A.rgb)+(_IdMap_var.g*_Color_B.rgb))+((_IdMap_var.b*_Color_C.rgb)+(node_8160.a*_Color_D.rgb)))*node_8160.rgb);
                float3 diffuseColor = ((_Rim_Color.rgb*(1.0 - pow(node_1050,_Rim_Pow1)))+node_724); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
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
                diffuseColor *= 1-specularMonochrome;
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
            uniform sampler2D _IdMap; uniform float4 _IdMap_ST;
            uniform sampler2D _Main; uniform float4 _Main_ST;
            uniform float _GL_A;
            uniform float _GL_B;
            uniform float _GL_C;
            uniform float _GL_D;
            uniform float _SP_A;
            uniform float _SP_B;
            uniform float _SP_C;
            uniform float _SP_D;
            uniform float4 _Color_A;
            uniform float4 _Color_B;
            uniform float4 _Color_D;
            uniform float4 _Color_C;
            uniform float _Rim_Pow1;
            uniform float4 _Rim_Color;
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
                
                o.Emission = 0;
                
                float node_1050 = dot(viewDirection,i.normalDir);
                float4 _IdMap_var = tex2D(_IdMap,TRANSFORM_TEX(i.uv0, _IdMap));
                float4 node_8160 = tex2D(_Main,TRANSFORM_TEX(i.uv0, _Main));
                float3 node_724 = ((((_IdMap_var.r*_Color_A.rgb)+(_IdMap_var.g*_Color_B.rgb))+((_IdMap_var.b*_Color_C.rgb)+(node_8160.a*_Color_D.rgb)))*node_8160.rgb);
                float3 diffColor = ((_Rim_Color.rgb*(1.0 - pow(node_1050,_Rim_Pow1)))+node_724);
                float node_2293 = lerp(lerp(lerp(lerp(0.0,_SP_A,_IdMap_var.r),_SP_B,_IdMap_var.g),_SP_C,_IdMap_var.b),_SP_D,node_8160.a);
                float3 specColor = float3(node_2293,node_2293,node_2293);
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0-specularMonochrome);
                float roughness = 1.0 - lerp(lerp(lerp(lerp(0.0,_GL_A,_IdMap_var.r),_GL_B,_IdMap_var.g),_GL_C,_IdMap_var.b),_GL_D,node_8160.a);
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
