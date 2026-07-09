using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000572")]
public class LoadingIcon : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000573")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59530C", Offset = "0x59530C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001CB6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UISprite, string> _003C_003E9__5_0;

		[Token(Token = "0x6002255")]
		[Address(RVA = "0x8C1D60", Offset = "0x8C1D60", VA = "0x8C1D60")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002256")]
		[Address(RVA = "0x8C1D68", Offset = "0x8C1D68", VA = "0x8C1D68")]
		internal string _003CAwake_003Eb__5_0(UISprite s)
		{
			return null;
		}
	}

	[Token(Token = "0x2000574")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59531C", Offset = "0x59531C")]
	private sealed class _003CAnimateAlpha_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CB8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001CBA")]
		[FieldOffset(Offset = "0x20")]
		public LoadingIcon _003C_003E4__this;

		[Token(Token = "0x170004EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x8C1F60", Offset = "0x8C1F60", VA = "0x8C1F60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x8C1FA8", Offset = "0x8C1FA8", VA = "0x8C1FA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002257")]
		[Address(RVA = "0x8C1D94", Offset = "0x8C1D94", VA = "0x8C1D94")]
		[DebuggerHidden]
		public _003CAnimateAlpha_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002258")]
		[Address(RVA = "0x8C1DC0", Offset = "0x8C1DC0", VA = "0x8C1DC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002259")]
		[Address(RVA = "0x8C1DC4", Offset = "0x8C1DC4", VA = "0x8C1DC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600225B")]
		[Address(RVA = "0x8C1F68", Offset = "0x8C1F68", VA = "0x8C1F68", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0x18")]
	public float MinAlpha;

	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxAlpha;

	[Token(Token = "0x4001CB3")]
	[FieldOffset(Offset = "0x20")]
	public float TransitionTime;

	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0x24")]
	private float _alphaStep;

	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0x28")]
	private UISprite[] _loadingIcons;

	[Token(Token = "0x600224F")]
	[Address(RVA = "0x9D211C", Offset = "0x9D211C", VA = "0x9D211C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002250")]
	[Address(RVA = "0x9D23B4", Offset = "0x9D23B4", VA = "0x9D23B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002251")]
	[Address(RVA = "0x9D244C", Offset = "0x9D244C", VA = "0x9D244C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002252")]
	[Address(RVA = "0x9D23E0", Offset = "0x9D23E0", VA = "0x9D23E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619C60", Offset = "0x619C60")]
	private IEnumerator AnimateAlpha()
	{
		return null;
	}

	[Token(Token = "0x6002253")]
	[Address(RVA = "0x9D24BC", Offset = "0x9D24BC", VA = "0x9D24BC")]
	public LoadingIcon()
	{
	}
}
