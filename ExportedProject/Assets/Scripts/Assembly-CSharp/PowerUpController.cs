using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053B")]
[AttributeAttribute(Name = "GameUpdateOrderAttribute", RVA = "0x5950D0", Offset = "0x5950D0")]
public class PowerUpController : UIController
{
	[Token(Token = "0x200053C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5950E4", Offset = "0x5950E4")]
	private sealed class _003CPowerUpUpdateCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BBD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BBE")]
		[FieldOffset(Offset = "0x20")]
		public PowerUpController _003C_003E4__this;

		[Token(Token = "0x170004D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x8B17D4", Offset = "0x8B17D4", VA = "0x8B17D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x8B181C", Offset = "0x8B181C", VA = "0x8B181C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x8B1618", Offset = "0x8B1618", VA = "0x8B1618")]
		[DebuggerHidden]
		public _003CPowerUpUpdateCoroutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x8B1644", Offset = "0x8B1644", VA = "0x8B1644", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x8B1648", Offset = "0x8B1648", VA = "0x8B1648", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x8B17DC", Offset = "0x8B17DC", VA = "0x8B17DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001BB5")]
	[FieldOffset(Offset = "0x50")]
	public ButtonHandler Button;

	[Token(Token = "0x4001BB6")]
	[FieldOffset(Offset = "0x58")]
	private GameTimer _activeTimer;

	[Token(Token = "0x4001BB7")]
	[FieldOffset(Offset = "0x60")]
	private GameTimer _cooldownTimer;

	[Token(Token = "0x4001BB8")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine _powerUpUpdateCoroutine;

	[Token(Token = "0x14000087")]
	public static event EventHandler PowerUpPressed
	{
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x940764", Offset = "0x940764", VA = "0x940764")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619438", Offset = "0x619438")]
		add
		{
		}
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x940820", Offset = "0x940820", VA = "0x940820")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619448", Offset = "0x619448")]
		remove
		{
		}
	}

	[Token(Token = "0x14000088")]
	public event EventHandler OnActiveStateChanged
	{
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x9408DC", Offset = "0x9408DC", VA = "0x9408DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619458", Offset = "0x619458")]
		add
		{
		}
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x94097C", Offset = "0x94097C", VA = "0x94097C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619468", Offset = "0x619468")]
		remove
		{
		}
	}

	[Token(Token = "0x14000089")]
	public event EventHandler OnRequestUpdateBlockedPowerUps
	{
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x940A1C", Offset = "0x940A1C", VA = "0x940A1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619478", Offset = "0x619478")]
		add
		{
		}
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x940ABC", Offset = "0x940ABC", VA = "0x940ABC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619488", Offset = "0x619488")]
		remove
		{
		}
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x940B5C", Offset = "0x940B5C", VA = "0x940B5C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x940BF8", Offset = "0x940BF8", VA = "0x940BF8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x941058", Offset = "0x941058", VA = "0x941058", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x941114", Offset = "0x941114", VA = "0x941114", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x940FEC", Offset = "0x940FEC", VA = "0x940FEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619498", Offset = "0x619498")]
	private IEnumerator PowerUpUpdateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x94145C", Offset = "0x94145C", VA = "0x94145C")]
	private void OnPowerUpClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x941B70", Offset = "0x941B70", VA = "0x941B70")]
	private void OnPowerUpPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x941C34", Offset = "0x941C34", VA = "0x941C34")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60020A5")]
	[Address(RVA = "0x940EA4", Offset = "0x940EA4", VA = "0x940EA4")]
	private void ResetPowerUp()
	{
	}

	[Token(Token = "0x60020A6")]
	[Address(RVA = "0x941678", Offset = "0x941678", VA = "0x941678")]
	public void ActivatePowerUp(bool activate)
	{
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x941CC8", Offset = "0x941CC8", VA = "0x941CC8")]
	private void OnShoot(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x941A50", Offset = "0x941A50", VA = "0x941A50")]
	private void StartCooldown()
	{
	}

	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x941EB4", Offset = "0x941EB4", VA = "0x941EB4")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x942254", Offset = "0x942254", VA = "0x942254")]
	private void OnRequestStartCooldownChanged(bool startCooldown)
	{
	}

	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x942324", Offset = "0x942324", VA = "0x942324")]
	private void OnRequestDeactivateChanged(bool shouldDeactivate)
	{
	}

	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x942400", Offset = "0x942400", VA = "0x942400")]
	public void OnEnterScope()
	{
	}

	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x942474", Offset = "0x942474", VA = "0x942474")]
	public PowerUpController()
	{
	}
}
