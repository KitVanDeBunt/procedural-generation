// Shader created with Shader Forge v1.17 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.17;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:2865,x:33360,y:32672,varname:node_2865,prsc:2|diff-4368-OUT,emission-2477-RGB,custl-4136-OUT;n:type:ShaderForge.SFN_Tex2d,id:5964,x:30544,y:33530,ptovrint:True,ptlb:Normal Map,ptin:_BumpMap,varname:_BumpMap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:479c92ee358411b489963d09aa1e8701,ntxv:0,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:5951,x:31108,y:32262,ptovrint:False,ptlb:flat,ptin:_flat,varname:node_5951,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:405977ae02a9ea6438a557c649bc89a2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3290,x:31958,y:31830,ptovrint:False,ptlb:steep,ptin:_steep,varname:node_3290,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:51f71974bbd7f8545a9a0cfc1c8e482f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3743,x:30774,y:32326,ptovrint:False,ptlb:top,ptin:_top,varname:node_3743,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b6714a6afca7d814baa40b8fb0053a23,ntxv:0,isnm:False;n:type:ShaderForge.SFN_NormalVector,id:2367,x:30819,y:31987,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:934,x:31057,y:32042,varname:node_934,prsc:2,dt:0|A-2533-OUT,B-2367-OUT;n:type:ShaderForge.SFN_Vector3,id:2533,x:30830,y:31876,varname:node_2533,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Power,id:7779,x:31872,y:32206,varname:node_7779,prsc:2|VAL-9895-OUT,EXP-397-OUT;n:type:ShaderForge.SFN_Slider,id:397,x:31364,y:32252,ptovrint:False,ptlb:top power,ptin:_toppower,varname:node_397,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:20;n:type:ShaderForge.SFN_Add,id:4368,x:32436,y:32396,cmnt:color,varname:node_4368,prsc:2|A-3882-OUT,B-4674-OUT;n:type:ShaderForge.SFN_Multiply,id:4674,x:32253,y:32426,varname:node_4674,prsc:2|A-7779-OUT,B-7491-OUT;n:type:ShaderForge.SFN_Multiply,id:3882,x:32208,y:31951,varname:node_3882,prsc:2|A-3290-RGB,B-2369-OUT;n:type:ShaderForge.SFN_OneMinus,id:3107,x:31728,y:31966,varname:node_3107,prsc:2|IN-9895-OUT;n:type:ShaderForge.SFN_Power,id:2369,x:31978,y:32003,varname:node_2369,prsc:2|VAL-3107-OUT,EXP-397-OUT;n:type:ShaderForge.SFN_Vector1,id:6480,x:31181,y:31792,varname:node_6480,prsc:2,v1:3;n:type:ShaderForge.SFN_Power,id:8076,x:31238,y:31922,varname:node_8076,prsc:2|VAL-934-OUT,EXP-6480-OUT;n:type:ShaderForge.SFN_Lerp,id:7491,x:31283,y:32392,varname:node_7491,prsc:2|A-5951-RGB,B-1392-OUT,T-6172-OUT;n:type:ShaderForge.SFN_ValueProperty,id:724,x:30940,y:32644,ptovrint:False,ptlb:snow Border,ptin:_snowBorder,varname:node_724,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.1;n:type:ShaderForge.SFN_FragmentPosition,id:872,x:30473,y:31804,varname:node_872,prsc:2;n:type:ShaderForge.SFN_Clamp01,id:6172,x:31108,y:32546,varname:node_6172,prsc:2|IN-6584-OUT;n:type:ShaderForge.SFN_Multiply,id:9509,x:30774,y:32498,varname:node_9509,prsc:2|A-7908-OUT,B-872-Y;n:type:ShaderForge.SFN_ValueProperty,id:7908,x:30748,y:32644,ptovrint:False,ptlb:snow lerp speed,ptin:_snowlerpspeed,varname:node_7908,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Divide,id:6584,x:30940,y:32498,varname:node_6584,prsc:2|A-9509-OUT,B-724-OUT;n:type:ShaderForge.SFN_LightVector,id:4160,x:31388,y:33582,varname:node_4160,prsc:2;n:type:ShaderForge.SFN_Dot,id:1953,x:31551,y:33524,cmnt:diffuse steep,varname:node_1953,prsc:2,dt:0|A-8695-OUT,B-4160-OUT;n:type:ShaderForge.SFN_Code,id:781,x:30750,y:33544,varname:node_781,prsc:2,code:ZgBsAG8AYQB0ADMAIABBADsACgBBAC4AeAAgAD0AIABuAG8AcgBtAC4AeAA7AAoAQQAuAHkAIAA9ACAAbgBvAHIAbQAuAHoAOwAKAEEALgB6ACAAPQAgAG4AbwByAG0ALgB5ADsACgAKAAoAcgBlAHQAdQByAG4AIABBADsA,output:2,fname:Function_node_781,width:312,height:181,input:2,input_1_label:norm|A-5964-RGB;n:type:ShaderForge.SFN_AmbientLight,id:2477,x:33175,y:32775,varname:node_2477,prsc:2;n:type:ShaderForge.SFN_Add,id:3784,x:32603,y:32861,varname:node_3784,prsc:2|A-9307-OUT,B-3836-RGB;n:type:ShaderForge.SFN_NormalVector,id:6462,x:30743,y:32864,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:8667,x:31171,y:32879,cmnt:light diffuse flattop,varname:node_8667,prsc:2,dt:0|A-9299-OUT,B-6462-OUT;n:type:ShaderForge.SFN_Multiply,id:7107,x:32206,y:32821,varname:node_7107,prsc:2|A-2369-OUT,B-8725-OUT;n:type:ShaderForge.SFN_Multiply,id:9442,x:32206,y:32674,varname:node_9442,prsc:2|A-7779-OUT,B-9032-OUT;n:type:ShaderForge.SFN_Add,id:1205,x:32423,y:32704,varname:node_1205,prsc:2|A-9442-OUT,B-7107-OUT;n:type:ShaderForge.SFN_LightColor,id:3836,x:32431,y:32957,varname:node_3836,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:9307,x:32431,y:32838,varname:node_9307,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4646,x:31427,y:31831,varname:node_4646,prsc:2|A-3921-OUT,B-8076-OUT;n:type:ShaderForge.SFN_Vector1,id:3921,x:31324,y:31727,varname:node_3921,prsc:2,v1:1;n:type:ShaderForge.SFN_Clamp01,id:474,x:31405,y:31954,varname:node_474,prsc:2|IN-4646-OUT;n:type:ShaderForge.SFN_Color,id:2077,x:30791,y:32160,ptovrint:False,ptlb:Snow Color,ptin:_SnowColor,varname:node_2077,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9,c2:0.9,c3:0.9,c4:1;n:type:ShaderForge.SFN_Multiply,id:1392,x:31108,y:32420,varname:node_1392,prsc:2|A-3743-RGB,B-2077-RGB;n:type:ShaderForge.SFN_Multiply,id:9202,x:32788,y:32772,varname:node_9202,prsc:2|A-4368-OUT,B-1205-OUT,C-3784-OUT;n:type:ShaderForge.SFN_LightVector,id:9299,x:30959,y:32751,varname:node_9299,prsc:2;n:type:ShaderForge.SFN_HalfVector,id:7675,x:30743,y:33007,varname:node_7675,prsc:2;n:type:ShaderForge.SFN_Dot,id:3004,x:31053,y:33019,varname:node_3004,prsc:2,dt:0|A-6462-OUT,B-7675-OUT;n:type:ShaderForge.SFN_Power,id:8254,x:31212,y:33029,varname:node_8254,prsc:2|VAL-3004-OUT,EXP-7817-OUT;n:type:ShaderForge.SFN_Slider,id:9265,x:30696,y:33238,ptovrint:False,ptlb:Glossiness flat/top,ptin:_Glossinessflattop,varname:node_9265,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:5,max:11;n:type:ShaderForge.SFN_Add,id:9032,x:31811,y:32899,varname:node_9032,prsc:2|A-8667-OUT,B-1175-OUT;n:type:ShaderForge.SFN_Slider,id:1915,x:31171,y:33231,ptovrint:False,ptlb:specularity flat/top,ptin:_specularityflattop,varname:node_1915,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:4;n:type:ShaderForge.SFN_Multiply,id:1483,x:31478,y:33049,varname:node_1483,prsc:2|A-8667-OUT,B-8254-OUT,C-1915-OUT;n:type:ShaderForge.SFN_Exp,id:7817,x:31053,y:33168,varname:node_7817,prsc:2,et:1|IN-9265-OUT;n:type:ShaderForge.SFN_HalfVector,id:2470,x:31217,y:33822,varname:node_2470,prsc:2;n:type:ShaderForge.SFN_Dot,id:5061,x:31401,y:33755,varname:node_5061,prsc:2,dt:0|A-8695-OUT,B-2470-OUT;n:type:ShaderForge.SFN_Power,id:5843,x:31563,y:33814,varname:node_5843,prsc:2|VAL-5061-OUT,EXP-600-OUT;n:type:ShaderForge.SFN_Slider,id:5458,x:31060,y:33983,ptovrint:False,ptlb:Glossiness syeed,ptin:_Glossinesssyeed,varname:_Glossinessflattop_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:5,max:11;n:type:ShaderForge.SFN_Slider,id:5877,x:31524,y:33960,ptovrint:False,ptlb:specularity steep,ptin:_specularitysteep,varname:_specularityflattop_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:4;n:type:ShaderForge.SFN_Multiply,id:749,x:31746,y:33814,varname:node_749,prsc:2|A-1953-OUT,B-5843-OUT,C-5877-OUT;n:type:ShaderForge.SFN_Exp,id:600,x:31401,y:33901,varname:node_600,prsc:2,et:1|IN-5458-OUT;n:type:ShaderForge.SFN_Add,id:8725,x:32127,y:33691,varname:node_8725,prsc:2|A-1953-OUT,B-4037-OUT;n:type:ShaderForge.SFN_Vector1,id:3070,x:32286,y:32597,varname:node_3070,prsc:2,v1:0;n:type:ShaderForge.SFN_Relay,id:9895,x:31611,y:32151,varname:node_9895,prsc:2|IN-474-OUT;n:type:ShaderForge.SFN_Clamp01,id:7795,x:31238,y:32100,varname:node_7795,prsc:2|IN-934-OUT;n:type:ShaderForge.SFN_Vector1,id:3453,x:31378,y:32109,varname:node_3453,prsc:2,v1:2;n:type:ShaderForge.SFN_Normalize,id:8695,x:31171,y:33543,varname:node_8695,prsc:2|IN-781-OUT;n:type:ShaderForge.SFN_Relay,id:4136,x:31273,y:33433,varname:node_4136,prsc:2|IN-1037-OUT;n:type:ShaderForge.SFN_Relay,id:1037,x:31171,y:33384,varname:node_1037,prsc:2|IN-9202-OUT;n:type:ShaderForge.SFN_Clamp01,id:1175,x:31638,y:33035,varname:node_1175,prsc:2|IN-1483-OUT;n:type:ShaderForge.SFN_Clamp01,id:4037,x:31919,y:33814,cmnt:speculat steep,varname:node_4037,prsc:2|IN-749-OUT;proporder:5964-5951-3743-397-3290-724-7908-2077-9265-1915-5458-5877;pass:END;sub:END;*/

Shader "Shader Forge/TerainTextured" {
    Properties {
        _BumpMap ("Normal Map", 2D) = "white" {}
        _flat ("flat", 2D) = "white" {}
        _top ("top", 2D) = "white" {}
        _toppower ("top power", Range(1, 20)) = 1
        _steep ("steep", 2D) = "white" {}
        _snowBorder ("snow Border", Float ) = 1.1
        _snowlerpspeed ("snow lerp speed", Float ) = 1
        _SnowColor ("Snow Color", Color) = (0.9,0.9,0.9,1)
        _Glossinessflattop ("Glossiness flat/top", Range(1, 11)) = 5
        _specularityflattop ("specularity flat/top", Range(0, 4)) = 1
        _Glossinesssyeed ("Glossiness syeed", Range(1, 11)) = 5
        _specularitysteep ("specularity steep", Range(0, 4)) = 1
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
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _BumpMap; uniform float4 _BumpMap_ST;
            uniform sampler2D _flat; uniform float4 _flat_ST;
            uniform sampler2D _steep; uniform float4 _steep_ST;
            uniform sampler2D _top; uniform float4 _top_ST;
            uniform float _toppower;
            uniform float _snowBorder;
            uniform float _snowlerpspeed;
            float3 Function_node_781( float3 norm ){
            float3 A;
            A.x = norm.x;
            A.y = norm.z;
            A.z = norm.y;
            
            
            return A;
            }
            
            uniform float4 _SnowColor;
            uniform float _Glossinessflattop;
            uniform float _specularityflattop;
            uniform float _Glossinesssyeed;
            uniform float _specularitysteep;
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float3 emissive = UNITY_LIGHTMODEL_AMBIENT.rgb;
                float4 _steep_var = tex2D(_steep,TRANSFORM_TEX(i.uv0, _steep));
                float node_934 = dot(float3(0,1,0),i.normalDir);
                float node_9895 = saturate((1.0*pow(node_934,3.0)));
                float node_2369 = pow((1.0 - node_9895),_toppower);
                float node_7779 = pow(node_9895,_toppower);
                float4 _flat_var = tex2D(_flat,TRANSFORM_TEX(i.uv0, _flat));
                float4 _top_var = tex2D(_top,TRANSFORM_TEX(i.uv0, _top));
                float3 node_4368 = ((_steep_var.rgb*node_2369)+(node_7779*lerp(_flat_var.rgb,(_top_var.rgb*_SnowColor.rgb),saturate(((_snowlerpspeed*i.posWorld.g)/_snowBorder))))); // color
                float node_8667 = dot(lightDirection,i.normalDir); // light diffuse flattop
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 node_8695 = normalize(Function_node_781( _BumpMap_var.rgb ));
                float node_1953 = dot(node_8695,lightDirection); // diffuse steep
                float3 finalColor = emissive + (node_4368*((node_7779*(node_8667+saturate((node_8667*pow(dot(i.normalDir,halfDirection),exp2(_Glossinessflattop))*_specularityflattop))))+(node_2369*(node_1953+saturate((node_1953*pow(dot(node_8695,halfDirection),exp2(_Glossinesssyeed))*_specularitysteep)))))*(attenuation+_LightColor0.rgb));
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
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _BumpMap; uniform float4 _BumpMap_ST;
            uniform sampler2D _flat; uniform float4 _flat_ST;
            uniform sampler2D _steep; uniform float4 _steep_ST;
            uniform sampler2D _top; uniform float4 _top_ST;
            uniform float _toppower;
            uniform float _snowBorder;
            uniform float _snowlerpspeed;
            float3 Function_node_781( float3 norm ){
            float3 A;
            A.x = norm.x;
            A.y = norm.z;
            A.z = norm.y;
            
            
            return A;
            }
            
            uniform float4 _SnowColor;
            uniform float _Glossinessflattop;
            uniform float _specularityflattop;
            uniform float _Glossinesssyeed;
            uniform float _specularitysteep;
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
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _steep_var = tex2D(_steep,TRANSFORM_TEX(i.uv0, _steep));
                float node_934 = dot(float3(0,1,0),i.normalDir);
                float node_9895 = saturate((1.0*pow(node_934,3.0)));
                float node_2369 = pow((1.0 - node_9895),_toppower);
                float node_7779 = pow(node_9895,_toppower);
                float4 _flat_var = tex2D(_flat,TRANSFORM_TEX(i.uv0, _flat));
                float4 _top_var = tex2D(_top,TRANSFORM_TEX(i.uv0, _top));
                float3 node_4368 = ((_steep_var.rgb*node_2369)+(node_7779*lerp(_flat_var.rgb,(_top_var.rgb*_SnowColor.rgb),saturate(((_snowlerpspeed*i.posWorld.g)/_snowBorder))))); // color
                float node_8667 = dot(lightDirection,i.normalDir); // light diffuse flattop
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 node_8695 = normalize(Function_node_781( _BumpMap_var.rgb ));
                float node_1953 = dot(node_8695,lightDirection); // diffuse steep
                float3 finalColor = (node_4368*((node_7779*(node_8667+saturate((node_8667*pow(dot(i.normalDir,halfDirection),exp2(_Glossinessflattop))*_specularityflattop))))+(node_2369*(node_1953+saturate((node_1953*pow(dot(node_8695,halfDirection),exp2(_Glossinesssyeed))*_specularitysteep)))))*(attenuation+_LightColor0.rgb));
                return fixed4(finalColor * 1,0);
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
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _flat; uniform float4 _flat_ST;
            uniform sampler2D _steep; uniform float4 _steep_ST;
            uniform sampler2D _top; uniform float4 _top_ST;
            uniform float _toppower;
            uniform float _snowBorder;
            uniform float _snowlerpspeed;
            uniform float4 _SnowColor;
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
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = UNITY_LIGHTMODEL_AMBIENT.rgb;
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
