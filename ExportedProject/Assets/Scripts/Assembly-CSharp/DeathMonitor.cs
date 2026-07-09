using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000443")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x593FF8", Offset = "0x593FF8")]
public class DeathMonitor : FsmStateAction
{
	[Token(Token = "0x2000444")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594030", Offset = "0x594030")]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x400179E")]
		[FieldOffset(Offset = "0x10")]
		public GameObject instigatorParent;

		[Token(Token = "0x400179F")]
		[FieldOffset(Offset = "0x18")]
		public Func<FsmGameObject, bool> _003C_003E9__1;

		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x86AEC4", Offset = "0x86AEC4", VA = "0x86AEC4")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x86AECC", Offset = "0x86AECC", VA = "0x86AECC")]
		internal bool _003CInstigatorsSatisfied_003Eb__1(FsmGameObject x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000445")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594040", Offset = "0x594040")]
	private sealed class _003C_003Ec__DisplayClass31_1
	{
		[Token(Token = "0x40017A0")]
		[FieldOffset(Offset = "0x10")]
		public DamageCollider currentDamageCollider;

		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x86AF60", Offset = "0x86AF60", VA = "0x86AF60")]
		public _003C_003Ec__DisplayClass31_1()
		{
		}

		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x86AF68", Offset = "0x86AF68", VA = "0x86AF68")]
		internal bool _003CInstigatorsSatisfied_003Eb__0(FsmGameObject x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000446")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594050", Offset = "0x594050")]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x40017A1")]
		[FieldOffset(Offset = "0x10")]
		public DamageCollider collider;

		[Token(Token = "0x40017A2")]
		[FieldOffset(Offset = "0x18")]
		public Func<Damage.Hit, bool> _003C_003E9__0;

		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x86B010", Offset = "0x86B010", VA = "0x86B010")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x86B018", Offset = "0x86B018", VA = "0x86B018")]
		internal bool _003CCollidersHaveBeenHit_003Eb__0(Damage.Hit hit)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000447")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594060", Offset = "0x594060")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40017A3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Damage.Hit, bool> _003C_003E9__34_0;

		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x86ADF0", Offset = "0x86ADF0", VA = "0x86ADF0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x86ADF8", Offset = "0x86ADF8", VA = "0x86ADF8")]
		internal bool _003COnCharacterDied_003Eb__34_0(Damage.Hit x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter Filter;

	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B5F88", Offset = "0x5B5F88")]
	public FsmGameObject NPC;

	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B5F9C", Offset = "0x5B5F9C")]
	public FsmGameObject CharacterSpawner;

	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0x68")]
	public bool ConditionHeadShotsOnly;

	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0x69")]
	public bool ConditionNoWitnesses;

	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0x6A")]
	public bool ConditionWasFocusedByTag;

	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0x6C")]
	public int ConditionQuickKillCount;

	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B5FB0", Offset = "0x5B5FB0")]
	public FsmInt ConditionQuickKillCountVar;

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5B5FC4", Offset = "0x5B5FC4")]
	public int ConditionSameBulletKillCount;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B5FFC", Offset = "0x5B5FFC")]
	public FsmInt ConditionSameBulletKillCountVar;

	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0x88")]
	public bool ConditionHoldBreath;

	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x89")]
	public bool ConditionWasMoving;

	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0x8A")]
	public bool ConditionIsTagged;

	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x8B")]
	public bool AddPlayerToInstigators;

	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x90")]
	public FsmGameObject[] Instigators;

	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x98")]
	public Damage.Types DamageType;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationConfig.MovementSpeed[] MovementSpeeds;

	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0xA8")]
	public DamageCollider[] CollidersToHit;

	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0xB0")]
	public FsmGameObject[] FSMCollidersToHit;

	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B6010", Offset = "0x5B6010")]
	public FsmEvent _ConditionsMetEvent;

	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B6048", Offset = "0x5B6048")]
	public FsmEvent _ConditionsNotMetEvent;

	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B6080", Offset = "0x5B6080")]
	public FsmEvent _AllDeadConditionsMetEvent;

	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B60B8", Offset = "0x5B60B8")]
	public FsmEvent _AllDeadConditionsNotMetEvent;

	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0xD8")]
	private bool _conditionsMet;

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0xE0")]
	private List<Spawner> _allSpawners;

	[Token(Token = "0x17000421")]
	public int ConditionQuickKillCountValue
	{
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0xAE535C", Offset = "0xAE535C", VA = "0xAE535C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000422")]
	public int ConditionSameBulletKillCountValue
	{
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0xAE53C0", Offset = "0xAE53C0", VA = "0xAE53C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001A07")]
	[Address(RVA = "0xAE5424", Offset = "0xAE5424", VA = "0xAE5424", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A08")]
	[Address(RVA = "0xAE54B0", Offset = "0xAE54B0", VA = "0xAE54B0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A09")]
	[Address(RVA = "0xAE56DC", Offset = "0xAE56DC", VA = "0xAE56DC")]
	private bool InstigatorsSatisfied(Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0xAE5A88", Offset = "0xAE5A88", VA = "0xAE5A88")]
	private bool IsFilterSatisfied(Character character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0xAE5AA8", Offset = "0xAE5AA8", VA = "0xAE5AA8")]
	private bool CollidersHaveBeenHit(Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0xAE5C5C", Offset = "0xAE5C5C", VA = "0xAE5C5C")]
	private void OnCharacterDied(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0xAE6304", Offset = "0xAE6304", VA = "0xAE6304", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0xAE6408", Offset = "0xAE6408", VA = "0xAE6408")]
	public DeathMonitor()
	{
	}
}
