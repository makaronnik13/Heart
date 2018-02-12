// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:1,cusa:True,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1873,x:33229,y:32719,varname:node_1873,prsc:2|emission-1749-OUT,alpha-603-OUT;n:type:ShaderForge.SFN_Multiply,id:1086,x:32808,y:32836,cmnt:RGB,varname:node_1086,prsc:2|A-5983-RGB,B-5376-RGB;n:type:ShaderForge.SFN_Color,id:5983,x:32568,y:33085,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2069637,c2:0.4334178,c3:0.9705882,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5376,x:32567,y:33367,varname:node_5376,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1749,x:33025,y:32818,cmnt:Premultiply Alpha,varname:node_1749,prsc:2|A-1086-OUT,B-603-OUT;n:type:ShaderForge.SFN_Multiply,id:603,x:32905,y:33149,cmnt:A,varname:node_603,prsc:2|A-2657-OUT,B-5983-A,C-5376-A;n:type:ShaderForge.SFN_Rotator,id:8765,x:32024,y:32471,varname:node_8765,prsc:2|UVIN-327-UVOUT,SPD-8272-OUT;n:type:ShaderForge.SFN_TexCoord,id:327,x:31819,y:32616,varname:node_327,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:6693,x:32241,y:32679,ptovrint:False,ptlb:Main2,ptin:_Main2,varname:_Main2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b622374d5d2aea745aad81458988651d,ntxv:0,isnm:False|UVIN-6770-UVOUT;n:type:ShaderForge.SFN_Rotator,id:6770,x:32022,y:32659,varname:node_6770,prsc:2|UVIN-327-UVOUT,SPD-3279-OUT;n:type:ShaderForge.SFN_Vector1,id:3279,x:31857,y:32778,varname:node_3279,prsc:2,v1:-0.3;n:type:ShaderForge.SFN_Multiply,id:226,x:32486,y:32696,varname:node_226,prsc:2|A-5847-A,B-6693-A,C-8063-OUT,D-2467-OUT;n:type:ShaderForge.SFN_Power,id:2657,x:32590,y:32836,varname:node_2657,prsc:2|VAL-226-OUT,EXP-1107-OUT;n:type:ShaderForge.SFN_Vector1,id:8272,x:31819,y:32537,varname:node_8272,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:6488,x:31675,y:33027,varname:node_6488,prsc:2|A-327-UVOUT,B-1115-OUT;n:type:ShaderForge.SFN_Pi,id:1115,x:31498,y:33027,varname:node_1115,prsc:2;n:type:ShaderForge.SFN_Sin,id:4292,x:31848,y:33071,varname:node_4292,prsc:2|IN-6488-OUT;n:type:ShaderForge.SFN_Power,id:2199,x:32021,y:33113,varname:node_2199,prsc:2|VAL-4292-OUT,EXP-3363-OUT;n:type:ShaderForge.SFN_Vector1,id:3363,x:31874,y:33201,varname:node_3363,prsc:2,v1:3;n:type:ShaderForge.SFN_ComponentMask,id:5229,x:32176,y:33113,varname:node_5229,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2199-OUT;n:type:ShaderForge.SFN_Min,id:8063,x:32326,y:33113,varname:node_8063,prsc:2|A-5229-R,B-5229-G;n:type:ShaderForge.SFN_Slider,id:2467,x:32486,y:32571,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:_Brightness,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10,max:10;n:type:ShaderForge.SFN_Vector1,id:1107,x:32326,y:32903,varname:node_1107,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:5847,x:32248,y:32398,ptovrint:False,ptlb:Main1,ptin:_Main1,varname:_Main1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:892de94187ec25e4da89f0e20990a7e3,ntxv:0,isnm:False|UVIN-8765-UVOUT;proporder:5983-6693-2467-5847;pass:END;sub:END;*/

Shader "Shader Forge/Bloom" {
    Properties {
        _Color ("Color", Color) = (0.2069637,0.4334178,0.9705882,1)
        _Main2 ("Main2", 2D) = "white" {}
        _Brightness ("Brightness", Range(0, 10)) = 10
        _Main1 ("Main1", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
            "CanUseSpriteAtlas"="True"
            "PreviewType"="Plane"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform sampler2D _Main2; uniform float4 _Main2_ST;
            uniform float _Brightness;
            uniform sampler2D _Main1; uniform float4 _Main1_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos(v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_6231 = _Time + _TimeEditor;
                float node_8765_ang = node_6231.g;
                float node_8765_spd = 0.2;
                float node_8765_cos = cos(node_8765_spd*node_8765_ang);
                float node_8765_sin = sin(node_8765_spd*node_8765_ang);
                float2 node_8765_piv = float2(0.5,0.5);
                float2 node_8765 = (mul(i.uv0-node_8765_piv,float2x2( node_8765_cos, -node_8765_sin, node_8765_sin, node_8765_cos))+node_8765_piv);
                float4 _Main1_var = tex2D(_Main1,TRANSFORM_TEX(node_8765, _Main1));
                float node_6770_ang = node_6231.g;
                float node_6770_spd = (-0.3);
                float node_6770_cos = cos(node_6770_spd*node_6770_ang);
                float node_6770_sin = sin(node_6770_spd*node_6770_ang);
                float2 node_6770_piv = float2(0.5,0.5);
                float2 node_6770 = (mul(i.uv0-node_6770_piv,float2x2( node_6770_cos, -node_6770_sin, node_6770_sin, node_6770_cos))+node_6770_piv);
                float4 _Main2_var = tex2D(_Main2,TRANSFORM_TEX(node_6770, _Main2));
                float2 node_5229 = pow(sin((i.uv0*3.141592654)),3.0).rg;
                float node_603 = (pow((_Main1_var.a*_Main2_var.a*min(node_5229.r,node_5229.g)*_Brightness),0.5)*_Color.a*i.vertexColor.a); // A
                float3 emissive = ((_Color.rgb*i.vertexColor.rgb)*node_603);
                float3 finalColor = emissive;
                return fixed4(finalColor,node_603);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
