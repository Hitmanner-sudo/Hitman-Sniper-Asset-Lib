using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C4")]
public class TutorialHoldBreath : TutorialToLearnLogic
{
	[Serializable]
	[Token(Token = "0x20002C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593164", Offset = "0x593164")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x8")]
		public static AimAtObjectHelper<Target>.ComponentGetter _003C_003E9__5_0;

		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x10")]
		public static AimAtObjectHelper<Target>.ComponentFilter _003C_003E9__5_1;

		[Token(Token = "0x6001102")]
		[Address(RVA = "0xA390DC", Offset = "0xA390DC", VA = "0xA390DC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0xA390E4", Offset = "0xA390E4", VA = "0xA390E4")]
		internal Target _003CDoStart_003Eb__5_0(RaycastHit h)
		{
			return null;
		}

		[Token(Token = "0x6001104")]
		[Address(RVA = "0xA39164", Offset = "0xA39164", VA = "0xA39164")]
		internal bool _003CDoStart_003Eb__5_1(Target t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593174", Offset = "0x593174")]
	private sealed class _003CShowTutorialCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x20")]
		public TutorialHoldBreath _003C_003E4__this;

		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x28")]
		private HUDModel.PauseMenuState _003CpauseState_003E5__2;

		[Token(Token = "0x1700028D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001108")]
			[Address(RVA = "0xA39594", Offset = "0xA39594", VA = "0xA39594", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600110A")]
			[Address(RVA = "0xA395DC", Offset = "0xA395DC", VA = "0xA395DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001105")]
		[Address(RVA = "0xA39184", Offset = "0xA39184", VA = "0xA39184")]
		[DebuggerHidden]
		public _003CShowTutorialCoroutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001106")]
		[Address(RVA = "0xA391B0", Offset = "0xA391B0", VA = "0xA391B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001107")]
		[Address(RVA = "0xA391B4", Offset = "0xA391B4", VA = "0xA391B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001109")]
		[Address(RVA = "0xA3959C", Offset = "0xA3959C", VA = "0xA3959C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F86")]
	[FieldOffset(Offset = "0x28")]
	private bool _didShowTutorial;

	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0x30")]
	private AimAtObjectHelper<Target> _targetAimer;

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0xCA3E94", Offset = "0xCA3E94", VA = "0xCA3E94")]
	public TutorialHoldBreath(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0xCA3EC0", Offset = "0xCA3EC0", VA = "0xCA3EC0", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0xCA3FE0", Offset = "0xCA3FE0", VA = "0xCA3FE0", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0xCA4084", Offset = "0xCA4084", VA = "0xCA4084", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010F8")]
	[Address(RVA = "0xCA44AC", Offset = "0xCA44AC", VA = "0xCA44AC", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0xCA45CC", Offset = "0xCA45CC", VA = "0xCA45CC", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0xCA4680", Offset = "0xCA4680", VA = "0xCA4680")]
	private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo e)
	{
	}

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0xCA46FC", Offset = "0xCA46FC", VA = "0xCA46FC", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0xCA4764", Offset = "0xCA4764", VA = "0xCA4764")]
	private void OnSlowMotionActivated(object sender, PlayerSlowMotionSystem.SlowMotionActivatedEventArgs args)
	{
	}

	[Token(Token = "0x60010FD")]
	[Address(RVA = "0xCA4868", Offset = "0xCA4868", VA = "0xCA4868")]
	private void ShowTutorial()
	{
	}

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0xCA4900", Offset = "0xCA4900", VA = "0xCA4900")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615C34", Offset = "0x615C34")]
	private IEnumerator ShowTutorialCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0xCA47B0", Offset = "0xCA47B0", VA = "0xCA47B0")]
	private void HideTutorial()
	{
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0xCA496C", Offset = "0xCA496C", VA = "0xCA496C")]
	private void SetInputEnabled(bool enabled)
	{
	}
}
