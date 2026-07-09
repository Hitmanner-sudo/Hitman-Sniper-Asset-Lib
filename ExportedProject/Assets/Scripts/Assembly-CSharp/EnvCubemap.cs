using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C3")]
public class EnvCubemap : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007C4")]
	public class CubemapTextureSet
	{
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x10")]
		public Material skybox;

		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D right;

		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D left;

		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D top;

		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D bottom;

		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D front;

		[Token(Token = "0x4002B94")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D back;

		[Token(Token = "0x600331D")]
		[Address(RVA = "0x86EAB4", Offset = "0x86EAB4", VA = "0x86EAB4")]
		public CubemapTextureSet()
		{
		}
	}

	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x18")]
	public CubemapTextureSet textureSet;

	[Token(Token = "0x4002B88")]
	[FieldOffset(Offset = "0x20")]
	public CubemapTextureSet textureSetBlurred;

	[Token(Token = "0x4002B89")]
	[FieldOffset(Offset = "0x28")]
	public CameraClearFlags clearFlags;

	[Token(Token = "0x4002B8A")]
	[FieldOffset(Offset = "0x2C")]
	public Color clearColor;

	[Token(Token = "0x4002B8B")]
	[FieldOffset(Offset = "0x3C")]
	public LayerMask cullingMask;

	[Token(Token = "0x4002B8C")]
	[FieldOffset(Offset = "0x40")]
	public float near;

	[Token(Token = "0x4002B8D")]
	[FieldOffset(Offset = "0x44")]
	public float far;

	[Token(Token = "0x600331C")]
	[Address(RVA = "0xE15FD4", Offset = "0xE15FD4", VA = "0xE15FD4")]
	public EnvCubemap()
	{
	}
}
