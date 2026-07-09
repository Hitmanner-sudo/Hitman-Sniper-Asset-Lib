using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20002CB")]
public class TutorialMiniObjectives : TutorialToLearnLogic
{
	[Token(Token = "0x20002CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593184", Offset = "0x593184")]
	private sealed class _003CDoStartCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x20")]
		public TutorialMiniObjectives _003C_003E4__this;

		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x28")]
		private ModelContainer _003Cmodel_003E5__2;

		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x30")]
		private HUDModel.PauseMenuState _003CpauseState_003E5__3;

		[Token(Token = "0x1700028F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001130")]
			[Address(RVA = "0xA39A00", Offset = "0xA39A00", VA = "0xA39A00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000290")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001132")]
			[Address(RVA = "0xA39A48", Offset = "0xA39A48", VA = "0xA39A48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600112D")]
		[Address(RVA = "0xA3965C", Offset = "0xA3965C", VA = "0xA3965C")]
		[DebuggerHidden]
		public _003CDoStartCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600112E")]
		[Address(RVA = "0xA39688", Offset = "0xA39688", VA = "0xA39688", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600112F")]
		[Address(RVA = "0xA3968C", Offset = "0xA3968C", VA = "0xA3968C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001131")]
		[Address(RVA = "0xA39A08", Offset = "0xA39A08", VA = "0xA39A08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F93")]
	private const float NO_INPUT_DURATION = 2f;

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x28")]
	private readonly Timer _timer;

	[Token(Token = "0x6001123")]
	[Address(RVA = "0xCA7880", Offset = "0xCA7880", VA = "0xCA7880")]
	public TutorialMiniObjectives(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001124")]
	[Address(RVA = "0xCA78F8", Offset = "0xCA78F8", VA = "0xCA78F8", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001125")]
	[Address(RVA = "0xCA79D0", Offset = "0xCA79D0", VA = "0xCA79D0", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001126")]
	[Address(RVA = "0xCA7A74", Offset = "0xCA7A74", VA = "0xCA7A74", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x6001127")]
	[Address(RVA = "0xCA7B28", Offset = "0xCA7B28", VA = "0xCA7B28", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x6001128")]
	[Address(RVA = "0xCA7BC0", Offset = "0xCA7BC0", VA = "0xCA7BC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615CE4", Offset = "0x615CE4")]
	private IEnumerator DoStartCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6001129")]
	[Address(RVA = "0xCA7C2C", Offset = "0xCA7C2C", VA = "0xCA7C2C", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x600112A")]
	[Address(RVA = "0xCA7D18", Offset = "0xCA7D18", VA = "0xCA7D18", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x600112B")]
	[Address(RVA = "0xCA7C84", Offset = "0xCA7C84", VA = "0xCA7C84")]
	private bool IsTouchDownThisFrame()
	{
		return default(bool);
	}

	[Token(Token = "0x600112C")]
	[Address(RVA = "0xCA7ED0", Offset = "0xCA7ED0", VA = "0xCA7ED0")]
	private void SetInputEnabled(bool enabled)
	{
	}
}
