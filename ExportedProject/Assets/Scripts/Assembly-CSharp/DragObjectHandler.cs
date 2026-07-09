using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000305")]
public class DragObjectHandler : MonoBehaviour
{
	[Token(Token = "0x2000306")]
	public class DragObjectEventArgs : EventArgs
	{
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x10")]
		public UIDragObject Sender;

		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x18")]
		public bool IsPressed;

		[Token(Token = "0x6001281")]
		[Address(RVA = "0x86C850", Offset = "0x86C850", VA = "0x86C850")]
		public DragObjectEventArgs()
		{
		}
	}

	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x20")]
	private UIDragObject _dragObj;

	[Token(Token = "0x1400004F")]
	public event EventHandler<DragObjectEventArgs> OnPressed
	{
		[Token(Token = "0x600127C")]
		[Address(RVA = "0xC1F2A8", Offset = "0xC1F2A8", VA = "0xC1F2A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616324", Offset = "0x616324")]
		add
		{
		}
		[Token(Token = "0x600127D")]
		[Address(RVA = "0xC1F348", Offset = "0xC1F348", VA = "0xC1F348")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616334", Offset = "0x616334")]
		remove
		{
		}
	}

	[Token(Token = "0x600127E")]
	[Address(RVA = "0xC1F3E8", Offset = "0xC1F3E8", VA = "0xC1F3E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600127F")]
	[Address(RVA = "0xC1F43C", Offset = "0xC1F43C", VA = "0xC1F43C")]
	private void OnPress(bool isDown)
	{
	}

	[Token(Token = "0x6001280")]
	[Address(RVA = "0xC1F4E0", Offset = "0xC1F4E0", VA = "0xC1F4E0")]
	public DragObjectHandler()
	{
	}
}
