using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075F")]
public class TallyRoulettePartItem : TallyRouletteItem
{
	[Token(Token = "0x2000760")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FA8", Offset = "0x595FA8")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0x10")]
		public TallyRoulettePartItem _003C_003E4__this;

		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0x18")]
		public UITweener[] flourishTweeners;

		[Token(Token = "0x6003111")]
		[Address(RVA = "0xA545EC", Offset = "0xA545EC", VA = "0xA545EC")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6003112")]
		[Address(RVA = "0xA545F4", Offset = "0xA545F4", VA = "0xA545F4")]
		internal void _003CDoAnimation_003Eb__0()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000761")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FB8", Offset = "0x595FB8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UITweener, bool> _003C_003E9__6_1;

		[Token(Token = "0x6003114")]
		[Address(RVA = "0xA545C8", Offset = "0xA545C8", VA = "0xA545C8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003115")]
		[Address(RVA = "0xA545D0", Offset = "0xA545D0", VA = "0xA545D0")]
		internal bool _003CDoAnimation_003Eb__6_1(UITweener t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000762")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FC8", Offset = "0x595FC8")]
	private sealed class _003CDoAnimation_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x20")]
		public TallyRoulettePartItem _003C_003E4__this;

		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		[Token(Token = "0x17000646")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003119")]
			[Address(RVA = "0xA54A6C", Offset = "0xA54A6C", VA = "0xA54A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000647")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600311B")]
			[Address(RVA = "0xA54AB4", Offset = "0xA54AB4", VA = "0xA54AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003116")]
		[Address(RVA = "0xA54708", Offset = "0xA54708", VA = "0xA54708")]
		[DebuggerHidden]
		public _003CDoAnimation_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003117")]
		[Address(RVA = "0xA54734", Offset = "0xA54734", VA = "0xA54734", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003118")]
		[Address(RVA = "0xA54738", Offset = "0xA54738", VA = "0xA54738", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600311A")]
		[Address(RVA = "0xA54A74", Offset = "0xA54A74", VA = "0xA54A74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TweenPosition _moveSprite;

	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _flourishGO;

	[Token(Token = "0x40029B6")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UITexture _flourishTexture;

	[Token(Token = "0x40029B7")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform _topAnchor;

	[Token(Token = "0x600310D")]
	[Address(RVA = "0xB50050", Offset = "0xB50050", VA = "0xB50050", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600310E")]
	[Address(RVA = "0xB50130", Offset = "0xB50130", VA = "0xB50130", Slot = "4")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0xB50180", Offset = "0xB50180", VA = "0xB50180", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621D10", Offset = "0x621D10")]
	public override IEnumerator DoAnimation()
	{
		return null;
	}

	[Token(Token = "0x6003110")]
	[Address(RVA = "0xB501EC", Offset = "0xB501EC", VA = "0xB501EC")]
	public TallyRoulettePartItem()
	{
	}
}
