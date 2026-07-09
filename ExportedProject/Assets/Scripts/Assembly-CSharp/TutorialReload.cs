using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20002D4")]
public class TutorialReload : TutorialToLearnLogic
{
	[Token(Token = "0x20002D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931B4", Offset = "0x5931B4")]
	private sealed class _003CDelayedShowHighlight_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x20")]
		private HUDModel.PauseMenuState _003CpauseState_003E5__2;

		[Token(Token = "0x17000293")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001174")]
			[Address(RVA = "0xA3A3A0", Offset = "0xA3A3A0", VA = "0xA3A3A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000294")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001176")]
			[Address(RVA = "0xA3A3E8", Offset = "0xA3A3E8", VA = "0xA3A3E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001171")]
		[Address(RVA = "0xA39FE4", Offset = "0xA39FE4", VA = "0xA39FE4")]
		[DebuggerHidden]
		public _003CDelayedShowHighlight_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001172")]
		[Address(RVA = "0xA3A010", Offset = "0xA3A010", VA = "0xA3A010", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001173")]
		[Address(RVA = "0xA3A014", Offset = "0xA3A014", VA = "0xA3A014", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001175")]
		[Address(RVA = "0xA3A3A8", Offset = "0xA3A3A8", VA = "0xA3A3A8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x28")]
	private int _displayTooltipOnAmmoCount;

	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x2C")]
	private int _highlightReloadOnAmmoCount;

	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x30")]
	private bool _highlightShown;

	[Token(Token = "0x6001164")]
	[Address(RVA = "0xCA9BC4", Offset = "0xCA9BC4", VA = "0xCA9BC4")]
	public TutorialReload(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001165")]
	[Address(RVA = "0xCA9BF8", Offset = "0xCA9BF8", VA = "0xCA9BF8", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6001166")]
	[Address(RVA = "0xCA9D5C", Offset = "0xCA9D5C", VA = "0xCA9D5C", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001167")]
	[Address(RVA = "0xCA9E00", Offset = "0xCA9E00", VA = "0xCA9E00", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x6001168")]
	[Address(RVA = "0xCA9FC8", Offset = "0xCA9FC8", VA = "0xCA9FC8")]
	private void OnWeaponShoot(object sender, Weapon.ShotFiredArgs shotFiredArgs)
	{
	}

	[Token(Token = "0x6001169")]
	[Address(RVA = "0xCAA0E4", Offset = "0xCAA0E4", VA = "0xCAA0E4")]
	private void OnReloadStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600116A")]
	[Address(RVA = "0xCAA0F4", Offset = "0xCAA0F4", VA = "0xCAA0F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615E54", Offset = "0x615E54")]
	private IEnumerator DelayedShowHighlight()
	{
		return null;
	}

	[Token(Token = "0x600116B")]
	[Address(RVA = "0xCAA150", Offset = "0xCAA150", VA = "0xCAA150", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x600116C")]
	[Address(RVA = "0xCAA3D8", Offset = "0xCAA3D8", VA = "0xCAA3D8", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x600116D")]
	[Address(RVA = "0xCA9EEC", Offset = "0xCA9EEC", VA = "0xCA9EEC")]
	private void ShowTooltip()
	{
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0xCAA368", Offset = "0xCAA368", VA = "0xCAA368")]
	private void HideTooltip()
	{
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0xCAA048", Offset = "0xCAA048", VA = "0xCAA048")]
	private void ShowHighlight()
	{
	}

	[Token(Token = "0x6001170")]
	[Address(RVA = "0xCAA3D4", Offset = "0xCAA3D4", VA = "0xCAA3D4")]
	private void HideHighlight()
	{
	}
}
