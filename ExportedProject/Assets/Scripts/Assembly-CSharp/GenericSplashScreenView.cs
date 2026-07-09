using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200066B")]
public class GenericSplashScreenView : View
{
	[Token(Token = "0x200066C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595888", Offset = "0x595888")]
	private sealed class _003CTimerDisplay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x20")]
		public GenericSplashScreenView _003C_003E4__this;

		[Token(Token = "0x1700055F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029A7")]
			[Address(RVA = "0x873FA8", Offset = "0x873FA8", VA = "0x873FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000560")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029A9")]
			[Address(RVA = "0x873FF0", Offset = "0x873FF0", VA = "0x873FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x873CF0", Offset = "0x873CF0", VA = "0x873CF0")]
		[DebuggerHidden]
		public _003CTimerDisplay_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x873D1C", Offset = "0x873D1C", VA = "0x873D1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x873D20", Offset = "0x873D20", VA = "0x873D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x873FB0", Offset = "0x873FB0", VA = "0x873FB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x60")]
	public float Duration;

	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x64")]
	public UIViewModel.UIScreen FirstLoadingScreen;

	[Token(Token = "0x4002390")]
	[FieldOffset(Offset = "0x68")]
	public UIViewModel.UIScreen NextScreen;

	[Token(Token = "0x4002391")]
	[FieldOffset(Offset = "0x70")]
	public UITexture Background;

	[Token(Token = "0x600299F")]
	[Address(RVA = "0xD9E784", Offset = "0xD9E784", VA = "0xD9E784", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60029A0")]
	[Address(RVA = "0xD9E8D0", Offset = "0xD9E8D0", VA = "0xD9E8D0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60029A1")]
	[Address(RVA = "0xD9E95C", Offset = "0xD9E95C", VA = "0xD9E95C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60029A2")]
	[Address(RVA = "0xD9E864", Offset = "0xD9E864", VA = "0xD9E864")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DE48", Offset = "0x61DE48")]
	public IEnumerator TimerDisplay()
	{
		return null;
	}

	[Token(Token = "0x60029A3")]
	[Address(RVA = "0xD9EA40", Offset = "0xD9EA40", VA = "0xD9EA40")]
	public GenericSplashScreenView()
	{
	}
}
