using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5928A0", Offset = "0x5928A0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5928A0", Offset = "0x5928A0")]
public class CharacterShadowController : MonoBehaviour
{
	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592934", Offset = "0x592934")]
	private sealed class _003CDoFadeOut_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x20")]
		public CharacterShadowController _003C_003E4__this;

		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x28")]
		private Material _003CcachedMaterial_003E5__2;

		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x30")]
		private float _003Celapsed_003E5__3;

		[Token(Token = "0x170001C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x862244", Offset = "0x862244", VA = "0x862244", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x86228C", Offset = "0x86228C", VA = "0x86228C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x8620B4", Offset = "0x8620B4", VA = "0x8620B4")]
		[DebuggerHidden]
		public _003CDoFadeOut_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x8620E0", Offset = "0x8620E0", VA = "0x8620E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x8620E4", Offset = "0x8620E4", VA = "0x8620E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x86224C", Offset = "0x86224C", VA = "0x86224C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x18")]
	public float ShadowFadeTime;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x1C")]
	private bool _hasFaded;

	[Token(Token = "0x170001BF")]
	public bool IsVisible
	{
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xAFD724", Offset = "0xAFD724", VA = "0xAFD724")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xAFD780", Offset = "0xAFD780", VA = "0xAFD780")]
		set
		{
		}
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0xAFD808", Offset = "0xAFD808", VA = "0xAFD808")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0xAFD8BC", Offset = "0xAFD8BC", VA = "0xAFD8BC")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0xAFD850", Offset = "0xAFD850", VA = "0xAFD850")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613DC4", Offset = "0x613DC4")]
	private IEnumerator DoFadeOut()
	{
		return null;
	}

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0xAFD92C", Offset = "0xAFD92C", VA = "0xAFD92C")]
	public CharacterShadowController()
	{
	}
}
