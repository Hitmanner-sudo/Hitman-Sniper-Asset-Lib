using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075A")]
public class TallyRouletteCashItem : TallyRouletteItem
{
	[Token(Token = "0x200075B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F78", Offset = "0x595F78")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x10")]
		public TallyRouletteCashItem _003C_003E4__this;

		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x18")]
		public UITweener[] flourishTweeners;

		[Token(Token = "0x60030FB")]
		[Address(RVA = "0xA540C0", Offset = "0xA540C0", VA = "0xA540C0")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60030FC")]
		[Address(RVA = "0xA540C8", Offset = "0xA540C8", VA = "0xA540C8")]
		internal void _003CDoAnimation_003Eb__0()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200075C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F88", Offset = "0x595F88")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UITweener, bool> _003C_003E9__5_1;

		[Token(Token = "0x60030FE")]
		[Address(RVA = "0xA5409C", Offset = "0xA5409C", VA = "0xA5409C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60030FF")]
		[Address(RVA = "0xA540A4", Offset = "0xA540A4", VA = "0xA540A4")]
		internal bool _003CDoAnimation_003Eb__5_1(UITweener t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200075D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F98", Offset = "0x595F98")]
	private sealed class _003CDoAnimation_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029A4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0x20")]
		public TallyRouletteCashItem _003C_003E4__this;

		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x17000644")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003103")]
			[Address(RVA = "0xA54518", Offset = "0xA54518", VA = "0xA54518", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000645")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003105")]
			[Address(RVA = "0xA54560", Offset = "0xA54560", VA = "0xA54560", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003100")]
		[Address(RVA = "0xA541B4", Offset = "0xA541B4", VA = "0xA541B4")]
		[DebuggerHidden]
		public _003CDoAnimation_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003101")]
		[Address(RVA = "0xA541E0", Offset = "0xA541E0", VA = "0xA541E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003102")]
		[Address(RVA = "0xA541E4", Offset = "0xA541E4", VA = "0xA541E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003104")]
		[Address(RVA = "0xA54520", Offset = "0xA54520", VA = "0xA54520", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400299B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TweenPosition _moveSprite;

	[Token(Token = "0x400299C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _valueFlourish;

	[Token(Token = "0x400299D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _valueFlourishLabel;

	[Token(Token = "0x400299E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform _topAnchor;

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0xB4FCB4", Offset = "0xB4FCB4", VA = "0xB4FCB4", Slot = "4")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0xB4FE50", Offset = "0xB4FE50", VA = "0xB4FE50", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621C60", Offset = "0x621C60")]
	public override IEnumerator DoAnimation()
	{
		return null;
	}

	[Token(Token = "0x60030FA")]
	[Address(RVA = "0xB4FEBC", Offset = "0xB4FEBC", VA = "0xB4FEBC")]
	public TallyRouletteCashItem()
	{
	}
}
