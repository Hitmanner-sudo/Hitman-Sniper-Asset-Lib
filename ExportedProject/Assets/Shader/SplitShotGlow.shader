Shader "SplitShotGlow" {
	Properties {
		_TintColor ("Tint Color", Vector) = (0.5,0.5,0.5,0.5)
		_FresnelExponent ("Fresnel Exponent", Range(0, 4)) = 2
		_FrenselClamp ("Fresnel Clamp", Range(1, 10)) = 1
		_Fresnel ("Fresnel Intensity", Range(0, 2)) = 1
		_OffsetScale ("Offset Scale", Range(0, 4)) = 0
		_SinusScale ("Sinus Scale", Range(0, 4)) = 0
		[Toggle] _Blend ("Blend", Range(0, 1)) = 0
		_BlendColor ("Blend Color", Vector) = (1,1,1,1)
		[NoScaleOffset] _BlendColorMap ("Blend Color Map", 2D) = "white" {}
		_BlendEmission ("Blend Emission", Vector) = (0,0,0,0)
		_BlendEmissionMap ("Blend Emission Map", 2D) = "white" {}
		_BlendStart ("Blend Start", Vector) = (0,0,0,1)
		_BlendEnd ("Blend End", Vector) = (0,1,0,1)
		_BlendFactor ("Blend Factor Map", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "VertexLit"
}