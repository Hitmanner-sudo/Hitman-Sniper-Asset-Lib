using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000616")]
public class ProgressionIcon : MonoBehaviour
{
	[Token(Token = "0x2000617")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5955F0", Offset = "0x5955F0")]
	private sealed class _003CAnimateDots_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x20")]
		public ProgressionIcon _003C_003E4__this;

		[Token(Token = "0x1700052C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002782")]
			[Address(RVA = "0x8B1BE8", Offset = "0x8B1BE8", VA = "0x8B1BE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x8B1C30", Offset = "0x8B1C30", VA = "0x8B1C30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600277F")]
		[Address(RVA = "0x8B1A08", Offset = "0x8B1A08", VA = "0x8B1A08")]
		[DebuggerHidden]
		public _003CAnimateDots_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002780")]
		[Address(RVA = "0x8B1A34", Offset = "0x8B1A34", VA = "0x8B1A34", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002781")]
		[Address(RVA = "0x8B1A38", Offset = "0x8B1A38", VA = "0x8B1A38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002783")]
		[Address(RVA = "0x8B1BF0", Offset = "0x8B1BF0", VA = "0x8B1BF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400218B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _transitionTime;

	[Token(Token = "0x400218C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int _spacingDots;

	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISprite _dotSprite;

	[Token(Token = "0x400218E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _dotsPerSide;

	[Token(Token = "0x400218F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UISprite _spriteToCenter;

	[Token(Token = "0x4002190")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector3 _offsetFromCorner;

	[Token(Token = "0x4002191")]
	[FieldOffset(Offset = "0x48")]
	private List<UISprite> _dotIcons;

	[Token(Token = "0x4002192")]
	[FieldOffset(Offset = "0x50")]
	private Color _colorOn;

	[Token(Token = "0x4002193")]
	[FieldOffset(Offset = "0x60")]
	private Color _colorOff;

	[Token(Token = "0x4002194")]
	[FieldOffset(Offset = "0x0")]
	private static int _currentDot;

	[Token(Token = "0x4002195")]
	[FieldOffset(Offset = "0x4")]
	private static int _previousDot;

	[Token(Token = "0x6002779")]
	[Address(RVA = "0xB38A50", Offset = "0xB38A50", VA = "0xB38A50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0xB38FB4", Offset = "0xB38FB4", VA = "0xB38FB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0xB3904C", Offset = "0xB3904C", VA = "0xB3904C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0xB38FE0", Offset = "0xB38FE0", VA = "0xB38FE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D1D0", Offset = "0x61D1D0")]
	private IEnumerator AnimateDots()
	{
		return null;
	}

	[Token(Token = "0x600277D")]
	[Address(RVA = "0xB390BC", Offset = "0xB390BC", VA = "0xB390BC")]
	public ProgressionIcon()
	{
	}
}
