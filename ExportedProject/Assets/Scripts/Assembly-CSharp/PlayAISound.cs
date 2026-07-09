using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000150")]
public class PlayAISound : GameMonoBehaviour
{
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59263C", Offset = "0x59263C")]
	private sealed class _003CEmitRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x20")]
		public PlayAISound _003C_003E4__this;

		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Cdelay_003E5__3;

		[Token(Token = "0x17000179")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x8D0CEC", Offset = "0x8D0CEC", VA = "0x8D0CEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x8D0D34", Offset = "0x8D0D34", VA = "0x8D0D34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x8D09C8", Offset = "0x8D09C8", VA = "0x8D09C8")]
		[DebuggerHidden]
		public _003CEmitRoutine_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x8D09F4", Offset = "0x8D09F4", VA = "0x8D09F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x8D09F8", Offset = "0x8D09F8", VA = "0x8D09F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x8D0CF4", Offset = "0x8D0CF4", VA = "0x8D0CF4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x48")]
	public AISound AISound;

	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B098C", Offset = "0x5B098C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B098C", Offset = "0x5B098C")]
	public float RepeatDelay;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x54")]
	public int PlayCount;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x58")]
	public float DelayBeforeFirstEmit;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x60")]
	private AIEmitter _emitter;

	[Token(Token = "0x6000908")]
	[Address(RVA = "0x90B134", Offset = "0x90B134", VA = "0x90B134", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000909")]
	[Address(RVA = "0x90B1F4", Offset = "0x90B1F4", VA = "0x90B1F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612B18", Offset = "0x612B18")]
	private IEnumerator EmitRoutine()
	{
		return null;
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x90B260", Offset = "0x90B260", VA = "0x90B260")]
	private void Emit()
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x90B360", Offset = "0x90B360", VA = "0x90B360")]
	public PlayAISound()
	{
	}
}
