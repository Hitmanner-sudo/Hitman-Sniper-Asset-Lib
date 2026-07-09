using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200056D")]
public class DragHandler : MonoBehaviour
{
	[Token(Token = "0x200056E")]
	public class DragEventArgs : EventArgs
	{
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B7C2C", Offset = "0x5B7C2C")]
		private Vector2 _003CDelta_003Ek__BackingField;

		[Token(Token = "0x170004ED")]
		public Vector2 Delta
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x86C7DC", Offset = "0x86C7DC", VA = "0x86C7DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619C40", Offset = "0x619C40")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x86C7E4", Offset = "0x86C7E4", VA = "0x86C7E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619C50", Offset = "0x619C50")]
			set
			{
			}
		}

		[Token(Token = "0x6002248")]
		[Address(RVA = "0x86C7EC", Offset = "0x86C7EC", VA = "0x86C7EC")]
		public DragEventArgs()
		{
		}
	}

	[Token(Token = "0x1400008C")]
	public event EventHandler<DragEventArgs> OnWidgetDrag
	{
		[Token(Token = "0x6002242")]
		[Address(RVA = "0xC1F0BC", Offset = "0xC1F0BC", VA = "0xC1F0BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619C20", Offset = "0x619C20")]
		add
		{
		}
		[Token(Token = "0x6002243")]
		[Address(RVA = "0xC1F15C", Offset = "0xC1F15C", VA = "0xC1F15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619C30", Offset = "0x619C30")]
		remove
		{
		}
	}

	[Token(Token = "0x6002244")]
	[Address(RVA = "0xC1F1FC", Offset = "0xC1F1FC", VA = "0xC1F1FC")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0xC1F2A0", Offset = "0xC1F2A0", VA = "0xC1F2A0")]
	public DragHandler()
	{
	}
}
