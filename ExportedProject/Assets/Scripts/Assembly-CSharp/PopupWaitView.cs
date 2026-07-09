using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20006BE")]
public class PopupWaitView : View
{
	[Token(Token = "0x20006BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B18", Offset = "0x595B18")]
	private sealed class _003CDoDotsAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x20")]
		public PopupWaitView _003C_003E4__this;

		[Token(Token = "0x170005B8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x8AFC18", Offset = "0x8AFC18", VA = "0x8AFC18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x8AFC60", Offset = "0x8AFC60", VA = "0x8AFC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x8AF8C0", Offset = "0x8AF8C0", VA = "0x8AF8C0")]
		[DebuggerHidden]
		public _003CDoDotsAnimation_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x8AF8EC", Offset = "0x8AF8EC", VA = "0x8AF8EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x8AF8F0", Offset = "0x8AF8F0", VA = "0x8AF8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x8AFC20", Offset = "0x8AFC20", VA = "0x8AFC20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40025CB")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ConnectText;

	[Token(Token = "0x40025CC")]
	[FieldOffset(Offset = "0x68")]
	public UILabel WaitText;

	[Token(Token = "0x40025CD")]
	[FieldOffset(Offset = "0x70")]
	public UISprite LogoSprite;

	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BackgroundSprite;

	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x80")]
	public string WaitLocKey;

	[Token(Token = "0x40025D0")]
	[FieldOffset(Offset = "0x88")]
	public string ConnectLocKey;

	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x90")]
	public float Delay;

	[Token(Token = "0x40025D2")]
	[FieldOffset(Offset = "0x94")]
	public int LateralOffset;

	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x98")]
	public int IntermediateOffset;

	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0xA0")]
	private string _beforeDots;

	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0xA8")]
	private string _afterDots;

	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0xB0")]
	private int _curDotIndex;

	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x93D2DC", Offset = "0x93D2DC", VA = "0x93D2DC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x93D3A0", Offset = "0x93D3A0", VA = "0x93D3A0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002C5E")]
	[Address(RVA = "0x93D770", Offset = "0x93D770", VA = "0x93D770", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C5F")]
	[Address(RVA = "0x93D704", Offset = "0x93D704", VA = "0x93D704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620608", Offset = "0x620608")]
	private IEnumerator DoDotsAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x93D79C", Offset = "0x93D79C", VA = "0x93D79C")]
	public PopupWaitView()
	{
	}
}
