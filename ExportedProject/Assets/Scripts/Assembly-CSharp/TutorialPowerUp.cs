using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002CE")]
public abstract class TutorialPowerUp : TutorialToLearnLogic
{
	[Serializable]
	[Token(Token = "0x20002CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593194", Offset = "0x593194")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x8")]
		public static AimAtObjectHelper<Target>.ComponentGetter _003C_003E9__7_0;

		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x10")]
		public static AimAtObjectHelper<Target>.ComponentFilter _003C_003E9__7_1;

		[Token(Token = "0x600114C")]
		[Address(RVA = "0xA39AB0", Offset = "0xA39AB0", VA = "0xA39AB0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600114D")]
		[Address(RVA = "0xA39AB8", Offset = "0xA39AB8", VA = "0xA39AB8")]
		internal Target _003CDoStart_003Eb__7_0(RaycastHit h)
		{
			return null;
		}

		[Token(Token = "0x600114E")]
		[Address(RVA = "0xA39B38", Offset = "0xA39B38", VA = "0xA39B38")]
		internal bool _003CDoStart_003Eb__7_1(Target t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931A4", Offset = "0x5931A4")]
	private sealed class _003CShowTutorial_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x20")]
		public TutorialPowerUp _003C_003E4__this;

		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x28")]
		private HUDModel.PauseMenuState _003CpauseState_003E5__2;

		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cidx_003E5__3;

		[Token(Token = "0x17000291")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001152")]
			[Address(RVA = "0xA39F94", Offset = "0xA39F94", VA = "0xA39F94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000292")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001154")]
			[Address(RVA = "0xA39FDC", Offset = "0xA39FDC", VA = "0xA39FDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600114F")]
		[Address(RVA = "0xA39B58", Offset = "0xA39B58", VA = "0xA39B58")]
		[DebuggerHidden]
		public _003CShowTutorial_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001150")]
		[Address(RVA = "0xA39B84", Offset = "0xA39B84", VA = "0xA39B84", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001151")]
		[Address(RVA = "0xA39B88", Offset = "0xA39B88", VA = "0xA39B88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001153")]
		[Address(RVA = "0xA39F9C", Offset = "0xA39F9C", VA = "0xA39F9C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x28")]
	private bool _completionPanelDisplayed;

	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x29")]
	private bool _didShowTutorial;

	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x30")]
	private AimAtObjectHelper<Target> _targetAimer;

	[Token(Token = "0x600113A")]
	[Address(RVA = "0xCA8784", Offset = "0xCA8784", VA = "0xCA8784")]
	protected TutorialPowerUp(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600113B")]
	[Address(RVA = "0xCA87B0", Offset = "0xCA87B0", VA = "0xCA87B0", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600113C")]
	[Address(RVA = "0xCA88DC", Offset = "0xCA88DC", VA = "0xCA88DC", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600113D")]
	[Address(RVA = "0xCA899C", Offset = "0xCA899C", VA = "0xCA899C", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x600113E")]
	[Address(RVA = "0xCA8A7C", Offset = "0xCA8A7C", VA = "0xCA8A7C", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0xCA8E8C", Offset = "0xCA8E8C", VA = "0xCA8E8C", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x6001140")]
	[Address(RVA = "0xCA8EF4", Offset = "0xCA8EF4", VA = "0xCA8EF4", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001141")]
	[Address(RVA = "0xCA8FE8", Offset = "0xCA8FE8", VA = "0xCA8FE8")]
	private void OnPowerUpUsed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001142")]
	[Address(RVA = "0xCA91D8", Offset = "0xCA91D8", VA = "0xCA91D8")]
	private void OnCompletionPanelDisplayChanged(object sender, HUDView.CompletionPanelDisplayChangedArgs e)
	{
	}

	[Token(Token = "0x6001143")]
	[Address(RVA = "0xCA91F4", Offset = "0xCA91F4", VA = "0xCA91F4")]
	private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo e)
	{
	}

	[Token(Token = "0x6001144")]
	[Address(RVA = "0xCA9270", Offset = "0xCA9270", VA = "0xCA9270")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615D94", Offset = "0x615D94")]
	private IEnumerator ShowTutorial()
	{
		return null;
	}

	[Token(Token = "0x6001145")]
	[Address(RVA = "0xCA9018", Offset = "0xCA9018", VA = "0xCA9018")]
	private void HideTutorial()
	{
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0xCA92DC", Offset = "0xCA92DC", VA = "0xCA92DC")]
	private void SetInputEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6001147")]
	protected abstract int GetTooltipIndex();

	[Token(Token = "0x6001148")]
	protected abstract SaveGameManager.SaveGameFlags GetSaveFlag();

	[Token(Token = "0x6001149")]
	protected abstract bool ShouldHidePowerUps();

	[Token(Token = "0x600114A")]
	[Address(RVA = "0xCA9354", Offset = "0xCA9354", VA = "0xCA9354")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615DF4", Offset = "0x615DF4")]
	private void _003CDoStart_003Eb__7_2()
	{
	}
}
