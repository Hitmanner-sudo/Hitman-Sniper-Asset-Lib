using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000576")]
public class LoadingText : MonoBehaviour
{
	[Token(Token = "0x2000577")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59532C", Offset = "0x59532C")]
	private sealed class _003CAnimateTexts_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001CCC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001CCD")]
		[FieldOffset(Offset = "0x20")]
		public LoadingText _003C_003E4__this;

		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0x28")]
		private string _003ClocalizedText_003E5__2;

		[Token(Token = "0x170004F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x8C2554", Offset = "0x8C2554", VA = "0x8C2554", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x8C259C", Offset = "0x8C259C", VA = "0x8C259C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002265")]
		[Address(RVA = "0x8C1FB0", Offset = "0x8C1FB0", VA = "0x8C1FB0")]
		[DebuggerHidden]
		public _003CAnimateTexts_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002266")]
		[Address(RVA = "0x8C1FDC", Offset = "0x8C1FDC", VA = "0x8C1FDC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002267")]
		[Address(RVA = "0x8C1FE0", Offset = "0x8C1FE0", VA = "0x8C1FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002269")]
		[Address(RVA = "0x8C255C", Offset = "0x8C255C", VA = "0x8C255C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel[] Labels;

	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x20")]
	public float TweenDuration;

	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x24")]
	public float CharacterDisplaySpeed;

	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x28")]
	public float TrolleySpeed;

	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x2C")]
	public float LineFadingSpeed;

	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x30")]
	public bool HasLoopingTexts;

	[Token(Token = "0x4001CC3")]
	[FieldOffset(Offset = "0x34")]
	public int LineSpacing;

	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x38")]
	public TextSettings[] TextSettingsContainer;

	[Token(Token = "0x4001CC5")]
	[FieldOffset(Offset = "0x0")]
	private static int _currentTextId;

	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x4")]
	private static int _currentCharacterDisplayed;

	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0x40")]
	private TextSettings _currentTextSettings;

	[Token(Token = "0x4001CC8")]
	[FieldOffset(Offset = "0x48")]
	private float _waitingTimeElpased;

	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x8")]
	private static bool _trolleyDisplayed;

	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x4C")]
	private bool _canPlayAnimation;

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x9D27B4", Offset = "0x9D27B4", VA = "0x9D27B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x9D27B8", Offset = "0x9D27B8", VA = "0x9D27B8")]
	private void Init()
	{
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x9D2C10", Offset = "0x9D2C10", VA = "0x9D2C10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002261")]
	[Address(RVA = "0x9D2CA8", Offset = "0x9D2CA8", VA = "0x9D2CA8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002262")]
	[Address(RVA = "0x9D2C3C", Offset = "0x9D2C3C", VA = "0x9D2C3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619D10", Offset = "0x619D10")]
	private IEnumerator AnimateTexts()
	{
		return null;
	}

	[Token(Token = "0x6002263")]
	[Address(RVA = "0x9D2D18", Offset = "0x9D2D18", VA = "0x9D2D18")]
	public LoadingText()
	{
	}
}
