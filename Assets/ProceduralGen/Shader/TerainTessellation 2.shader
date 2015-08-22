// Shader created with Shader Forge v1.17 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.17;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:9361,x:33402,y:32636,varname:node_9361,prsc:2|spec-5237-OUT,gloss-6960-OUT,custl-6115-OUT,disp-6099-OUT,tess-8174-OUT;n:type:ShaderForge.SFN_Tex2d,id:1955,x:31773,y:32564,varname:node_1955,prsc:2,tex:324e8ddddcb42244cad106025d8aed96,ntxv:0,isnm:False|TEX-4475-TEX;n:type:ShaderForge.SFN_Multiply,id:9856,x:32757,y:33008,varname:node_9856,prsc:2|A-712-OUT,B-3266-OUT,C-9651-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3266,x:32576,y:33096,ptovrint:False,ptlb:displace power,ptin:_displacepower,varname:node_3266,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector3,id:712,x:32576,y:32986,varname:node_712,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_ViewPosition,id:6160,x:31621,y:33370,varname:node_6160,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:9947,x:31621,y:33253,varname:node_9947,prsc:2;n:type:ShaderForge.SFN_Distance,id:4102,x:31932,y:33436,varname:node_4102,prsc:2|A-9947-XYZ,B-6160-XYZ;n:type:ShaderForge.SFN_Divide,id:4825,x:32307,y:33436,varname:node_4825,prsc:2|A-7132-OUT,B-7774-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7774,x:32082,y:33602,ptovrint:False,ptlb:max dist,ptin:_maxdist,varname:node_7774,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1000;n:type:ShaderForge.SFN_Min,id:7132,x:32132,y:33436,varname:node_7132,prsc:2|A-4102-OUT,B-7774-OUT;n:type:ShaderForge.SFN_Subtract,id:7934,x:32481,y:33436,varname:node_7934,prsc:2|A-8761-OUT,B-4825-OUT;n:type:ShaderForge.SFN_Multiply,id:4511,x:32654,y:33436,varname:node_4511,prsc:2|A-8155-OUT,B-7934-OUT;n:type:ShaderForge.SFN_Max,id:2219,x:32815,y:33416,varname:node_2219,prsc:2|A-8761-OUT,B-4511-OUT;n:type:ShaderForge.SFN_ObjectPosition,id:9302,x:31621,y:33115,varname:node_9302,prsc:2;n:type:ShaderForge.SFN_Subtract,id:5566,x:32409,y:33032,varname:node_5566,prsc:2|A-9947-Y,B-2041-OUT;n:type:ShaderForge.SFN_Subtract,id:9651,x:32576,y:33154,varname:node_9651,prsc:2|A-5566-OUT,B-1180-OUT;n:type:ShaderForge.SFN_Vector1,id:8761,x:32498,y:33378,varname:node_8761,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:1180,x:32409,y:33154,varname:node_1180,prsc:2|A-1955-G,B-909-OUT;n:type:ShaderForge.SFN_Vector1,id:1182,x:32219,y:33278,varname:node_1182,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:8155,x:32290,y:33592,ptovrint:False,ptlb:tes pow,ptin:_tespow,varname:node_8155,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:5.77387,max:100;n:type:ShaderForge.SFN_Subtract,id:8292,x:32931,y:33124,varname:node_8292,prsc:2|A-9856-OUT,B-7337-OUT;n:type:ShaderForge.SFN_Multiply,id:7337,x:32757,y:33154,varname:node_7337,prsc:2|A-712-OUT,B-9947-XYZ;n:type:ShaderForge.SFN_Ceil,id:6463,x:33140,y:33442,varname:node_6463,prsc:2|IN-8531-OUT;n:type:ShaderForge.SFN_Multiply,id:8531,x:32983,y:33349,varname:node_8531,prsc:2|A-5673-OUT,B-2219-OUT;n:type:ShaderForge.SFN_Vector1,id:5673,x:32815,y:33323,varname:node_5673,prsc:2,v1:2;n:type:ShaderForge.SFN_Add,id:8174,x:33323,y:33317,varname:node_8174,prsc:2|A-1922-OUT,B-6463-OUT;n:type:ShaderForge.SFN_Vector1,id:1922,x:33105,y:33292,varname:node_1922,prsc:2,v1:-1;n:type:ShaderForge.SFN_Multiply,id:6189,x:32387,y:32423,varname:node_6189,prsc:2|A-1955-RGB,B-8467-RGB;n:type:ShaderForge.SFN_Color,id:8467,x:32233,y:32619,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:5237,x:32514,y:32699,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:6960,x:32514,y:32790,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_ValueProperty,id:909,x:32108,y:33287,ptovrint:False,ptlb:terainHeight,ptin:_terainHeight,varname:node_909,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:699,x:32128,y:32416,ptovrint:False,ptlb:snow,ptin:_snow,varname:node_699,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8734a6f3f3507594b850390f0aa195c1,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8589,x:32128,y:32179,ptovrint:False,ptlb:grass,ptin:_grass,varname:node_8589,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:405977ae02a9ea6438a557c649bc89a2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:3594,x:32444,y:32277,varname:node_3594,prsc:2|A-699-RGB,B-8589-RGB,T-6189-OUT;n:type:ShaderForge.SFN_LightVector,id:147,x:32592,y:32048,varname:node_147,prsc:2;n:type:ShaderForge.SFN_Dot,id:3807,x:32889,y:32173,varname:node_3807,prsc:2,dt:1|A-147-OUT,B-9581-OUT;n:type:ShaderForge.SFN_Multiply,id:6115,x:32998,y:32445,varname:node_6115,prsc:2|A-3594-OUT,B-9518-RGB,C-5706-OUT,D-3807-OUT;n:type:ShaderForge.SFN_LightColor,id:9518,x:32662,y:32516,varname:node_9518,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:4475,x:31542,y:32536,ptovrint:False,ptlb:height map,ptin:_heightmap,varname:node_4475,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:324e8ddddcb42244cad106025d8aed96,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:931,x:32419,y:32126,ptovrint:False,ptlb:normal map,ptin:_normalmap,varname:node_931,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:68f9744ac3424744faef56d13866d545,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Vector3,id:9639,x:32344,y:32026,varname:node_9639,prsc:2,v1:0.5,v2:0.5,v3:0;n:type:ShaderForge.SFN_NormalVector,id:1532,x:32209,y:31931,prsc:2,pt:False;n:type:ShaderForge.SFN_Code,id:9581,x:32531,y:31681,varname:node_9581,prsc:2,code:cgBlAHQAdQByAG4AIABBAC4AZwBiAHIAOwA=,output:2,fname:normalfix,width:416,height:248,input:2,input_1_label:A|A-931-RGB;n:type:ShaderForge.SFN_LightAttenuation,id:5706,x:32662,y:32398,varname:node_5706,prsc:2;n:type:ShaderForge.SFN_Vector1,id:2041,x:31744,y:33087,varname:node_2041,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:7364,x:32889,y:32841,ptovrint:False,ptlb:Y displacement,ptin:_Ydisplacement,varname:node_7364,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Code,id:2415,x:31063,y:33863,varname:node_2415,prsc:2,code:ZgBsAG8AYQB0ADMAIABBADsACgBBAC4AeAAgAD0AIABpAG4ALgB4ADsACgBBAC4AeQAgAD0AIAAtAGkAbgAuAHkAOwAKAEEALgB6ACAAPQAgAGkAbgAuAHoAOwAKAAoACgByAGUAdAB1AHIAbgAgAG8AdQB0ADsA,output:2,fname:Function_node_781,width:402,height:181,input:2,input_1_label:norm;n:type:ShaderForge.SFN_Vector3,id:8268,x:32889,y:32901,varname:node_8268,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Multiply,id:3139,x:33042,y:32857,varname:node_3139,prsc:2|A-7364-OUT,B-8268-OUT;n:type:ShaderForge.SFN_Add,id:6099,x:33227,y:32904,varname:node_6099,prsc:2|A-3139-OUT,B-8292-OUT;proporder:3266-7774-8155-5237-6960-8467-909-699-8589-4475-931-7364;pass:END;sub:END;*/

Shader "Shader Forge/TerainTest" {
    Properties {
        _displacepower ("displace power", Float ) = 1
        _maxdist ("max dist", Float ) = 1000
        _tespow ("tes pow", Range(1, 100)) = 5.77387
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Gloss ("Gloss", Range(0, 1)) = 0.8
        _Color ("Color", Color) = (1,1,1,1)
        _terainHeight ("terainHeight", Float ) = 1
        _snow ("snow", 2D) = "white" {}
        _grass ("grass", 2D) = "white" {}
        _heightmap ("height map", 2D) = "white" {}
        _normalmap ("normal map", 2D) = "bump" {}
        _Ydisplacement ("Y displacement", Float ) = 0
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            uniform float _displacepower;
            uniform float _maxdist;
            uniform float _tespow;
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _terainHeight;
            uniform sampler2D _snow; uniform float4 _snow_ST;
            uniform sampler2D _grass; uniform float4 _grass_ST;
            uniform sampler2D _heightmap; uniform float4 _heightmap_ST;
            uniform sampler2D _normalmap; uniform float4 _normalmap_ST;
            float3 normalfix( float3 A ){
            return A.gbr;
            }
            
            uniform float _Ydisplacement;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float3 node_712 = float3(0,1,0);
                    float4 node_1955 = tex2Dlod(_heightmap,float4(TRANSFORM_TEX(v.texcoord0, _heightmap),0.0,0));
                    v.vertex.xyz += ((_Ydisplacement*float3(0,1,0))+((node_712*_displacepower*((mul(_Object2World, v.vertex).g-0.0)-(node_1955.g*_terainHeight)))-(node_712*mul(_Object2World, v.vertex).rgb)));
                }
                float Tessellation(TessVertex v){
                    float node_8761 = 1.0;
                    return ((-1.0)+ceil((2.0*max(node_8761,(_tespow*(node_8761-(min(distance(mul(_Object2World, v.vertex).rgb,_WorldSpaceCameraPos),_maxdist)/_maxdist)))))));
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _snow_var = tex2D(_snow,TRANSFORM_TEX(i.uv0, _snow));
                float4 _grass_var = tex2D(_grass,TRANSFORM_TEX(i.uv0, _grass));
                float4 node_1955 = tex2D(_heightmap,TRANSFORM_TEX(i.uv0, _heightmap));
                float3 _normalmap_var = UnpackNormal(tex2D(_normalmap,TRANSFORM_TEX(i.uv0, _normalmap)));
                float3 finalColor = (lerp(_snow_var.rgb,_grass_var.rgb,(node_1955.rgb*_Color.rgb))*_LightColor0.rgb*attenuation*max(0,dot(lightDirection,normalfix( _normalmap_var.rgb ))));
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            uniform float _displacepower;
            uniform float _maxdist;
            uniform float _tespow;
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _terainHeight;
            uniform sampler2D _snow; uniform float4 _snow_ST;
            uniform sampler2D _grass; uniform float4 _grass_ST;
            uniform sampler2D _heightmap; uniform float4 _heightmap_ST;
            uniform sampler2D _normalmap; uniform float4 _normalmap_ST;
            float3 normalfix( float3 A ){
            return A.gbr;
            }
            
            uniform float _Ydisplacement;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                LIGHTING_COORDS(2,3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float3 node_712 = float3(0,1,0);
                    float4 node_1955 = tex2Dlod(_heightmap,float4(TRANSFORM_TEX(v.texcoord0, _heightmap),0.0,0));
                    v.vertex.xyz += ((_Ydisplacement*float3(0,1,0))+((node_712*_displacepower*((mul(_Object2World, v.vertex).g-0.0)-(node_1955.g*_terainHeight)))-(node_712*mul(_Object2World, v.vertex).rgb)));
                }
                float Tessellation(TessVertex v){
                    float node_8761 = 1.0;
                    return ((-1.0)+ceil((2.0*max(node_8761,(_tespow*(node_8761-(min(distance(mul(_Object2World, v.vertex).rgb,_WorldSpaceCameraPos),_maxdist)/_maxdist)))))));
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _snow_var = tex2D(_snow,TRANSFORM_TEX(i.uv0, _snow));
                float4 _grass_var = tex2D(_grass,TRANSFORM_TEX(i.uv0, _grass));
                float4 node_1955 = tex2D(_heightmap,TRANSFORM_TEX(i.uv0, _heightmap));
                float3 _normalmap_var = UnpackNormal(tex2D(_normalmap,TRANSFORM_TEX(i.uv0, _normalmap)));
                float3 finalColor = (lerp(_snow_var.rgb,_grass_var.rgb,(node_1955.rgb*_Color.rgb))*_LightColor0.rgb*attenuation*max(0,dot(lightDirection,normalfix( _normalmap_var.rgb ))));
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            uniform float _displacepower;
            uniform float _maxdist;
            uniform float _tespow;
            uniform float _terainHeight;
            uniform sampler2D _heightmap; uniform float4 _heightmap_ST;
            uniform float _Ydisplacement;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float3 node_712 = float3(0,1,0);
                    float4 node_1955 = tex2Dlod(_heightmap,float4(TRANSFORM_TEX(v.texcoord0, _heightmap),0.0,0));
                    v.vertex.xyz += ((_Ydisplacement*float3(0,1,0))+((node_712*_displacepower*((mul(_Object2World, v.vertex).g-0.0)-(node_1955.g*_terainHeight)))-(node_712*mul(_Object2World, v.vertex).rgb)));
                }
                float Tessellation(TessVertex v){
                    float node_8761 = 1.0;
                    return ((-1.0)+ceil((2.0*max(node_8761,(_tespow*(node_8761-(min(distance(mul(_Object2World, v.vertex).rgb,_WorldSpaceCameraPos),_maxdist)/_maxdist)))))));
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
