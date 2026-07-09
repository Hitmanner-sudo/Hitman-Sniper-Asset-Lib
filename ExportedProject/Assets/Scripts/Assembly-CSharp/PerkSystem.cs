using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000428")]
[Scope]
public class PerkSystem : GameSingleton<PerkSystem>
{
	[Token(Token = "0x2000429")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593BF0", Offset = "0x593BF0")]
	private sealed class _003CCreateNextUnlockPopupAfterOldDestruction_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x20")]
		public PerkSystem _003C_003E4__this;

		[Token(Token = "0x17000414")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001992")]
			[Address(RVA = "0x8CF878", Offset = "0x8CF878", VA = "0x8CF878", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000415")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x8CF8C0", Offset = "0x8CF8C0", VA = "0x8CF8C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600198F")]
		[Address(RVA = "0x8CF774", Offset = "0x8CF774", VA = "0x8CF774")]
		[DebuggerHidden]
		public _003CCreateNextUnlockPopupAfterOldDestruction_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001990")]
		[Address(RVA = "0x8CF7A0", Offset = "0x8CF7A0", VA = "0x8CF7A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001991")]
		[Address(RVA = "0x8CF7A4", Offset = "0x8CF7A4", VA = "0x8CF7A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001993")]
		[Address(RVA = "0x8CF880", Offset = "0x8CF880", VA = "0x8CF880", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PerkPopup;

	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x50")]
	public OfferDescription PerkPurchaseOfferDescription;

	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x58")]
	private readonly Queue<Perk> _perkUnlocksQueue;

	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x60")]
	private Perk _currentlyDisplayedPerk;

	[Token(Token = "0x6001980")]
	[Address(RVA = "0x901D2C", Offset = "0x901D2C", VA = "0x901D2C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001981")]
	[Address(RVA = "0x901E0C", Offset = "0x901E0C", VA = "0x901E0C")]
	private void OnContractAboutToChange(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x901EA8", Offset = "0x901EA8", VA = "0x901EA8")]
	private void OnContractChanged(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001983")]
	[Address(RVA = "0x901E14", Offset = "0x901E14", VA = "0x901E14")]
	private void ActivateCurrentContractPerks(bool activate)
	{
	}

	[Token(Token = "0x6001984")]
	[Address(RVA = "0x901EB0", Offset = "0x901EB0", VA = "0x901EB0")]
	public Perk[] GetCurrentContractPerks()
	{
		return null;
	}

	[Token(Token = "0x6001985")]
	[Address(RVA = "0x8FDA60", Offset = "0x8FDA60", VA = "0x8FDA60")]
	public void OnPerkUnlocked(Perk perk)
	{
	}

	[Token(Token = "0x6001986")]
	[Address(RVA = "0x902064", Offset = "0x902064", VA = "0x902064")]
	private void CreateNextUnlockPopup()
	{
	}

	[Token(Token = "0x6001987")]
	[Address(RVA = "0x90224C", Offset = "0x90224C", VA = "0x90224C")]
	private void OnUnlockAnimationEnded(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x6001988")]
	[Address(RVA = "0x902278", Offset = "0x902278", VA = "0x902278")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617694", Offset = "0x617694")]
	private IEnumerator CreateNextUnlockPopupAfterOldDestruction()
	{
		return null;
	}

	[Token(Token = "0x6001989")]
	[Address(RVA = "0x901498", Offset = "0x901498", VA = "0x901498")]
	public PerkItemView CreatePerkItem(Perk perk, GameObject parent, GameObject prefab, bool isHalfPriceWeaponOwned)
	{
		return null;
	}

	[Token(Token = "0x600198A")]
	[Address(RVA = "0x9018F8", Offset = "0x9018F8", VA = "0x9018F8")]
	public void DestroyPerkItem(PerkItemView perkItem)
	{
	}

	[Token(Token = "0x600198B")]
	[Address(RVA = "0x901FD8", Offset = "0x901FD8", VA = "0x901FD8")]
	private static void ActivatePerk(Perk perk)
	{
	}

	[Token(Token = "0x600198C")]
	[Address(RVA = "0x902044", Offset = "0x902044", VA = "0x902044")]
	private static void DeactivatePerk(Perk perk)
	{
	}

	[Token(Token = "0x600198D")]
	[Address(RVA = "0x9022E4", Offset = "0x9022E4", VA = "0x9022E4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600198E")]
	[Address(RVA = "0x902428", Offset = "0x902428", VA = "0x902428")]
	public PerkSystem()
	{
	}
}
