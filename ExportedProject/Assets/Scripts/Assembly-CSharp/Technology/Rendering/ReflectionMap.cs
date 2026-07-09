using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Rendering
{
	[Token(Token = "0x2000B9F")]
	[ExecuteInEditMode]
	public class ReflectionMap : MonoBehaviour
	{
		[Token(Token = "0x4003AAC")]
		private const float DEBUG_LINE_LENGTH = 5f;

		[Token(Token = "0x4003AAD")]
		private const float DEBUG_CUBE_DEPTH = 0.001f;

		[Token(Token = "0x4003AAE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3 Normal;

		[Token(Token = "0x4003AAF")]
		[FieldOffset(Offset = "0xC")]
		public static readonly Vector3 Up;

		[Token(Token = "0x4003AB0")]
		[FieldOffset(Offset = "0x18")]
		public Transform ViewPosition;

		[Token(Token = "0x4003AB1")]
		[FieldOffset(Offset = "0x20")]
		public float FieldOfView;

		[Token(Token = "0x4003AB2")]
		[FieldOffset(Offset = "0x24")]
		public float FarClip;

		[Token(Token = "0x4003AB3")]
		[FieldOffset(Offset = "0x28")]
		public float NearClip;

		[Token(Token = "0x4003AB4")]
		[FieldOffset(Offset = "0x2C")]
		public int TextureSize;

		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D reflectionTexture;

		[Token(Token = "0x1700094A")]
		public float Aspect
		{
			[Token(Token = "0x60049DC")]
			[Address(RVA = "0x9629FC", Offset = "0x9629FC", VA = "0x9629FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700094B")]
		public Vector3 WorldNormal
		{
			[Token(Token = "0x60049DD")]
			[Address(RVA = "0x962A58", Offset = "0x962A58", VA = "0x962A58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700094C")]
		public Vector3 Reflect
		{
			[Token(Token = "0x60049DE")]
			[Address(RVA = "0x962B10", Offset = "0x962B10", VA = "0x962B10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700094D")]
		public float ViewHeight
		{
			[Token(Token = "0x60049DF")]
			[Address(RVA = "0x962BF4", Offset = "0x962BF4", VA = "0x962BF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700094E")]
		public float ViewDistance
		{
			[Token(Token = "0x60049E0")]
			[Address(RVA = "0x962C20", Offset = "0x962C20", VA = "0x962C20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700094F")]
		public Vector3 TopLeft
		{
			[Token(Token = "0x60049E1")]
			[Address(RVA = "0x962D6C", Offset = "0x962D6C", VA = "0x962D6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000950")]
		public Vector3 TopRight
		{
			[Token(Token = "0x60049E2")]
			[Address(RVA = "0x962D9C", Offset = "0x962D9C", VA = "0x962D9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000951")]
		public Vector3 BottomLeft
		{
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x962DCC", Offset = "0x962DCC", VA = "0x962DCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000952")]
		public Vector3 BottomRight
		{
			[Token(Token = "0x60049E4")]
			[Address(RVA = "0x962DFC", Offset = "0x962DFC", VA = "0x962DFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x962924", Offset = "0x962924", VA = "0x962924")]
		private void Awake()
		{
		}

		[Token(Token = "0x60049E5")]
		[Address(RVA = "0x962E2C", Offset = "0x962E2C", VA = "0x962E2C")]
		public ReflectionMap()
		{
		}
	}
}
