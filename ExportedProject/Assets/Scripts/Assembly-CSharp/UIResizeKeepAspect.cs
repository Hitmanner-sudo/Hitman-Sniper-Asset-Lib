using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A7")]
public class UIResizeKeepAspect : MonoBehaviour
{
	[Token(Token = "0x20007A8")]
	public class ResizeArgs
	{
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x10")]
		public int OriginalWidth;

		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x14")]
		public int OriginalHeight;

		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x18")]
		public int NewWidth;

		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x1C")]
		public int NewHeight;

		[Token(Token = "0x6003293")]
		[Address(RVA = "0xA3E070", Offset = "0xA3E070", VA = "0xA3E070")]
		public ResizeArgs()
		{
		}
	}

	[Token(Token = "0x4002B12")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _container;

	[Token(Token = "0x140000AB")]
	public event Action<ResizeArgs> OnResized
	{
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x142D1CC", Offset = "0x142D1CC", VA = "0x142D1CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622620", Offset = "0x622620")]
		add
		{
		}
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x142D26C", Offset = "0x142D26C", VA = "0x142D26C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622630", Offset = "0x622630")]
		remove
		{
		}
	}

	[Token(Token = "0x6003291")]
	[Address(RVA = "0x142D30C", Offset = "0x142D30C", VA = "0x142D30C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6003292")]
	[Address(RVA = "0x142D480", Offset = "0x142D480", VA = "0x142D480")]
	public UIResizeKeepAspect()
	{
	}
}
