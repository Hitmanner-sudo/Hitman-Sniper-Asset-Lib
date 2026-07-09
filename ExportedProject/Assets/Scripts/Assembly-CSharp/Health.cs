using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20001B1")]
public class Health : GameMonoBehaviour
{
	[Token(Token = "0x20001B2")]
	public class TakeDamageEventArgs : EventArgs
	{
		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B21C8", Offset = "0x5B21C8")]
		private float _003CPreviousHealth_003Ek__BackingField;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B21D8", Offset = "0x5B21D8")]
		private Damage _003CDamage_003Ek__BackingField;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int WitnessCount;

		[Token(Token = "0x170001DE")]
		public float PreviousHealth
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xB200E4", Offset = "0xB200E4", VA = "0xB200E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614074", Offset = "0x614074")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0xB200EC", Offset = "0xB200EC", VA = "0xB200EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614084", Offset = "0x614084")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public Damage Damage
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0xB200F4", Offset = "0xB200F4", VA = "0xB200F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614094", Offset = "0x614094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0xB200FC", Offset = "0xB200FC", VA = "0xB200FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140A4", Offset = "0x6140A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xB20104", Offset = "0xB20104", VA = "0xB20104")]
		public TakeDamageEventArgs()
		{
		}
	}

	[Token(Token = "0x20001B3")]
	public class TakeHealEventArgs : EventArgs
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B21E8", Offset = "0x5B21E8")]
		private float _003CPreviousHealth_003Ek__BackingField;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B21F8", Offset = "0x5B21F8")]
		private Heal _003CHeal_003Ek__BackingField;

		[Token(Token = "0x170001E0")]
		public float PreviousHealth
		{
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0xB20168", Offset = "0xB20168", VA = "0xB20168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140B4", Offset = "0x6140B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0xB20170", Offset = "0xB20170", VA = "0xB20170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140C4", Offset = "0x6140C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public Heal Heal
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0xB20178", Offset = "0xB20178", VA = "0xB20178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140D4", Offset = "0x6140D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0xB20180", Offset = "0xB20180", VA = "0xB20180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140E4", Offset = "0x6140E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xB20188", Offset = "0xB20188", VA = "0xB20188")]
		public TakeHealEventArgs()
		{
		}
	}

	[Token(Token = "0x20001B4")]
	public struct SpawnEffectData
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject ParentGO;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LazyGameObject EffectLazyGO;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;
	}

	[Token(Token = "0x20001B5")]
	public class DamageOverTimeData
	{
		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DamageOverTime DamageOverTime;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> Effects;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AppliedTime;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float DeathTime;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject Instigator;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Faction InstigatorFaction;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameTimer NextDotTickTimer;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long BulletID;

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xB2000C", Offset = "0xB2000C", VA = "0xB2000C")]
		public DamageOverTimeData(DamageOverTime damageOverTime, List<GameObject> effects, float appliedTime, float deathTime, GameObject instigator, Faction instigatorFaction, long bulletID)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xB200C4", Offset = "0xB200C4", VA = "0xB200C4")]
		public void StartDotTimer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592964", Offset = "0x592964")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Converter<DamageOverTimeData, Damage.Types> _003C_003E9__26_0;

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xB1FF14", Offset = "0xB1FF14", VA = "0xB1FF14")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0xB1FF1C", Offset = "0xB1FF1C", VA = "0xB1FF1C")]
		internal Damage.Types _003Cget_DotsType_003Eb__26_0(DamageOverTimeData x)
		{
			return default(Damage.Types);
		}
	}

	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592974", Offset = "0x592974")]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DamageOverTime dotToApply;

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0xB1FF40", Offset = "0xB1FF40", VA = "0xB1FF40")]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xB1FF48", Offset = "0xB1FF48", VA = "0xB1FF48")]
		internal bool _003CApplyDotDamage_003Eb__0(DamageOverTimeData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float MaxHealth;

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float RegenerationRate;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float HealthCount;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private long _lastHitBulletID;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _totalDamagePerBullet;

	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float _timeOfDeath;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<Damage> _damageHistory;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<DamageOverTimeData> _damageOverTimeList;

	[Token(Token = "0x4000952")]
	private const float DOT_TICK_TIME = 1f;

	[Token(Token = "0x170001D5")]
	public bool Alive
	{
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xA0A5D4", Offset = "0xA0A5D4", VA = "0xA0A5D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D6")]
	public bool Dead
	{
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xA0A5E4", Offset = "0xA0A5E4", VA = "0xA0A5E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D7")]
	public bool Wounded
	{
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xA0A5F4", Offset = "0xA0A5F4", VA = "0xA0A5F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D8")]
	public bool Full
	{
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xA0A608", Offset = "0xA0A608", VA = "0xA0A608")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D9")]
	public float TimeOfDeath
	{
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xA0A61C", Offset = "0xA0A61C", VA = "0xA0A61C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001DA")]
	public List<Damage> DamageHistory
	{
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xA0A624", Offset = "0xA0A624", VA = "0xA0A624")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DB")]
	public Damage LastDamage
	{
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xA09F6C", Offset = "0xA09F6C", VA = "0xA09F6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DC")]
	public bool Doted
	{
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xA0A62C", Offset = "0xA0A62C", VA = "0xA0A62C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001DD")]
	public List<Damage.Types> DotsType
	{
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xA0A684", Offset = "0xA0A684", VA = "0xA0A684")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000020")]
	public event EventHandler<TakeDamageEventArgs> OnPreTakeDamage
	{
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xA0A7C0", Offset = "0xA0A7C0", VA = "0xA0A7C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613FD4", Offset = "0x613FD4")]
		add
		{
		}
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xA0A860", Offset = "0xA0A860", VA = "0xA0A860")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613FE4", Offset = "0x613FE4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000021")]
	public event EventHandler<TakeDamageEventArgs> OnTakeDamage
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xA0A900", Offset = "0xA0A900", VA = "0xA0A900")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613FF4", Offset = "0x613FF4")]
		add
		{
		}
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xA0A9A0", Offset = "0xA0A9A0", VA = "0xA0A9A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614004", Offset = "0x614004")]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	public event EventHandler<TakeHealEventArgs> OnTakeHeal
	{
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xA0AA40", Offset = "0xA0AA40", VA = "0xA0AA40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614014", Offset = "0x614014")]
		add
		{
		}
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0xA0AAE0", Offset = "0xA0AAE0", VA = "0xA0AAE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614024", Offset = "0x614024")]
		remove
		{
		}
	}

	[Token(Token = "0x14000023")]
	public event EventHandler<TakeDamageEventArgs> OnDied
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0xA0AB80", Offset = "0xA0AB80", VA = "0xA0AB80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614034", Offset = "0x614034")]
		add
		{
		}
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xA0AC20", Offset = "0xA0AC20", VA = "0xA0AC20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614044", Offset = "0x614044")]
		remove
		{
		}
	}

	[Token(Token = "0x14000024")]
	public static event EventHandler<TakeDamageEventArgs> GlobalOnTakeDamage
	{
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xA0ACC0", Offset = "0xA0ACC0", VA = "0xA0ACC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614054", Offset = "0x614054")]
		add
		{
		}
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xA0AD7C", Offset = "0xA0AD7C", VA = "0xA0AD7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614064", Offset = "0x614064")]
		remove
		{
		}
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0xA0AE38", Offset = "0xA0AE38", VA = "0xA0AE38", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0xA0AE64", Offset = "0xA0AE64", VA = "0xA0AE64", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0xA0AF30", Offset = "0xA0AF30", VA = "0xA0AF30", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0xA0B078", Offset = "0xA0B078", VA = "0xA0B078")]
	private void ApplyDots(float currentGameTime)
	{
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0xA0B1C0", Offset = "0xA0B1C0", VA = "0xA0B1C0")]
	private void DoDotDamage(DamageOverTimeData dot)
	{
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0xA0B2D8", Offset = "0xA0B2D8", VA = "0xA0B2D8")]
	private void DeleteDot(int dotIndex)
	{
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0xA0B4A0", Offset = "0xA0B4A0", VA = "0xA0B4A0")]
	private void StopDotEffects(int dotIndex)
	{
	}

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0xA0B65C", Offset = "0xA0B65C", VA = "0xA0B65C")]
	public void StopAllDotEffects()
	{
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0xA0B6CC", Offset = "0xA0B6CC", VA = "0xA0B6CC")]
	public void InitHealth(float maxHealth)
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0xA0B6D8", Offset = "0xA0B6D8", VA = "0xA0B6D8", Slot = "14")]
	public virtual void Heal(Heal heal)
	{
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0xA0B7BC", Offset = "0xA0B7BC", VA = "0xA0B7BC", Slot = "15")]
	public virtual void TakeDamage(Damage damage, [Optional] DamageOverTime dot)
	{
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0xA0C0A0", Offset = "0xA0C0A0", VA = "0xA0C0A0")]
	public void Die(Damage.Types type, GameObject killer, Faction instigatorFaction)
	{
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0xA0C1AC", Offset = "0xA0C1AC", VA = "0xA0C1AC")]
	public void Die(Damage damage)
	{
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0xA0BAEC", Offset = "0xA0BAEC", VA = "0xA0BAEC")]
	public void ApplyDotDamage(DamageOverTime dotToApply, GameObject instigator, Faction instigatorFaction, long bulletID)
	{
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0xA0C218", Offset = "0xA0C218", VA = "0xA0C218")]
	private List<GameObject> SpawnEffects(List<SpawnEffectData> spawnEffects, int maxEffectToSpawn = -1)
	{
		return null;
	}

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0xA0C438", Offset = "0xA0C438", VA = "0xA0C438")]
	public Health()
	{
	}
}
