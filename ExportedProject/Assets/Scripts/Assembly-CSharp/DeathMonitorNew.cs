using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000448")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594070", Offset = "0x594070")]
public class DeathMonitorNew : FsmStateAction
{
	[Token(Token = "0x2000449")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5940A8", Offset = "0x5940A8")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x10")]
		public GameObject instigatorParent;

		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x18")]
		public Func<GameObject, bool> _003C_003E9__0;

		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x86B09C", Offset = "0x86B09C", VA = "0x86B09C")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x86B0A4", Offset = "0x86B0A4", VA = "0x86B0A4")]
		internal bool _003CInstigatorsSatisfied_003Eb__0(GameObject x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200044A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5940B8", Offset = "0x5940B8")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x10")]
		public string factionName;

		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x18")]
		public Health health;

		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x86B11C", Offset = "0x86B11C", VA = "0x86B11C")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x86B124", Offset = "0x86B124", VA = "0x86B124")]
		internal bool _003CSatisfiedBy_003Eb__0(UnityEngine.Object x)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x86B15C", Offset = "0x86B15C", VA = "0x86B15C")]
		internal bool _003CSatisfiedBy_003Eb__1(int x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B60F0", Offset = "0x5B60F0")]
	public FsmGameObject OutNPC;

	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6104", Offset = "0x5B6104")]
	public FsmArray BodyParts;

	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6118", Offset = "0x5B6118")]
	public FsmBool ConditionNoWitnesses;

	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B612C", Offset = "0x5B612C")]
	public FsmBool ConditionWasFocusedByTag;

	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6140", Offset = "0x5B6140")]
	public FsmInt ConditionQuickKillCount;

	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6154", Offset = "0x5B6154")]
	[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5B6154", Offset = "0x5B6154")]
	public FsmInt ConditionSameBulletKillCount;

	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B61A4", Offset = "0x5B61A4")]
	public FsmBool ConditionHoldBreath;

	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B61B8", Offset = "0x5B61B8")]
	public FsmBool AddPlayerToInstigators;

	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B61CC", Offset = "0x5B61CC")]
	public FsmArray Instigators;

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B61E0", Offset = "0x5B61E0")]
	public FsmArray DamageTypes;

	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B61F4", Offset = "0x5B61F4")]
	public FsmEvent _ConditionsMetEvent;

	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B622C", Offset = "0x5B622C")]
	public FsmEvent _ConditionsNotMetEvent;

	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0xB0")]
	private long _lastDamageIDCausingDeath;

	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0xB8")]
	private int _validDeaths;

	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6264", Offset = "0x5B6264")]
	public FsmBool ConditionIsTagged;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6278", Offset = "0x5B6278")]
	public FsmBool ConditionIsNotTagged;

	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B628C", Offset = "0x5B628C")]
	public FsmBool ConditionIsNotHeadshot;

	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B62A0", Offset = "0x5B62A0")]
	public FsmBool ConditionIsNotAccident;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B62B4", Offset = "0x5B62B4")]
	public FsmArray MovementSpeeds;

	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B62C8", Offset = "0x5B62C8")]
	public FsmFloat MinDistance;

	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B62DC", Offset = "0x5B62DC")]
	public FsmFloat MaxDistance;

	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B62F0", Offset = "0x5B62F0")]
	public FsmArray Factions;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6304", Offset = "0x5B6304")]
	public FsmArray NPCSpawner;

	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6318", Offset = "0x5B6318")]
	public FsmArray Behaviours;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B632C", Offset = "0x5B632C")]
	public FsmArray HealthCondition;

	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6340", Offset = "0x5B6340")]
	public FsmBool MainTarget;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x120")]
	private List<Spawner> _flattenedSpawners;

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0xAE64B8", Offset = "0xAE64B8", VA = "0xAE64B8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0xAE6554", Offset = "0xAE6554", VA = "0xAE6554", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0xAE65E4", Offset = "0xAE65E4", VA = "0xAE65E4")]
	private bool InstigatorsSatisfied(Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0xAE6898", Offset = "0xAE6898", VA = "0xAE6898")]
	private void OnCharacterDied(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0xAE7294", Offset = "0xAE7294", VA = "0xAE7294")]
	private bool CheckNoWitness(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0xAE72E0", Offset = "0xAE72E0", VA = "0xAE72E0")]
	private bool CheckWasFocusedByTag(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0xAE734C", Offset = "0xAE734C", VA = "0xAE734C")]
	private bool CheckQuickKill()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0xAE76E8", Offset = "0xAE76E8", VA = "0xAE76E8")]
	private bool CheckSameBulletCount(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A20")]
	[Address(RVA = "0xAE7420", Offset = "0xAE7420", VA = "0xAE7420")]
	private bool CheckHoldBreath(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A21")]
	[Address(RVA = "0xAE7484", Offset = "0xAE7484", VA = "0xAE7484")]
	private bool CheckDamageTypes(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A22")]
	[Address(RVA = "0xAE7534", Offset = "0xAE7534", VA = "0xAE7534")]
	private bool CheckBodyParts(Character.DeathEvent args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A23")]
	[Address(RVA = "0xAE7650", Offset = "0xAE7650", VA = "0xAE7650")]
	private bool MultipleKillsRequired()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A24")]
	[Address(RVA = "0xAE76A4", Offset = "0xAE76A4", VA = "0xAE76A4")]
	private void UpdateValidDeathsCount(Damage damage)
	{
	}

	[Token(Token = "0x6001A25")]
	[Address(RVA = "0xAE7724", Offset = "0xAE7724", VA = "0xAE7724", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0xAE6A80", Offset = "0xAE6A80", VA = "0xAE6A80")]
	public bool SatisfiedBy(Character character, Damage damage, Vector3 relativePosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A27")]
	[Address(RVA = "0xAE781C", Offset = "0xAE781C", VA = "0xAE781C")]
	private void FlattenSpawners()
	{
	}

	[Token(Token = "0x6001A28")]
	[Address(RVA = "0xAE7A0C", Offset = "0xAE7A0C", VA = "0xAE7A0C")]
	public DeathMonitorNew()
	{
	}
}
