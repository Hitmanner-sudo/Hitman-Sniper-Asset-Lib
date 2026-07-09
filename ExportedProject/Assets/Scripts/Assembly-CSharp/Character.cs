using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000172")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5926EC", Offset = "0x5926EC")]
public abstract class Character : GameMonoBehaviour
{
	[Token(Token = "0x2000173")]
	public class DeathEvent : EventArgs
	{
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x10")]
		public Character Character;

		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x18")]
		public Damage Damage;

		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x20")]
		public bool FromHoldBreath;

		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x21")]
		public bool Despawned;

		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0A74", Offset = "0x5B0A74")]
		private int _003CWitnessCount_003Ek__BackingField;

		[Token(Token = "0x17000188")]
		public int WitnessCount
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x8618B8", Offset = "0x8618B8", VA = "0x8618B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612CD8", Offset = "0x612CD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x8618C0", Offset = "0x8618C0", VA = "0x8618C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612CE8", Offset = "0x612CE8")]
			set
			{
			}
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x8618C8", Offset = "0x8618C8", VA = "0x8618C8")]
		public DeathEvent()
		{
		}
	}

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0A44", Offset = "0x5B0A44")]
	private Controller _003CController_003Ek__BackingField;

	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x50")]
	public CharacterGender Gender;

	[NonSerialized]
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x58")]
	public Spawner SpawnedFrom;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 _velocity;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x70")]
	public Faction VisibleFaction;

	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x78")]
	private Health _health;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x80")]
	public Inventory Inventory;

	[Token(Token = "0x17000182")]
	public Controller Controller
	{
		[Token(Token = "0x600098F")]
		[Address(RVA = "0xAFA1EC", Offset = "0xAFA1EC", VA = "0xAFA1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C78", Offset = "0x612C78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000990")]
		[Address(RVA = "0xAFA1F4", Offset = "0xAFA1F4", VA = "0xAFA1F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C88", Offset = "0x612C88")]
		set
		{
		}
	}

	[Token(Token = "0x17000183")]
	public virtual Vector3 EyePosition
	{
		[Token(Token = "0x6000991")]
		[Address(RVA = "0xAFA1FC", Offset = "0xAFA1FC", VA = "0xAFA1FC", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000184")]
	public virtual Vector3 EyeDirection
	{
		[Token(Token = "0x6000992")]
		[Address(RVA = "0xAFA218", Offset = "0xAFA218", VA = "0xAFA218", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000185")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000993")]
		[Address(RVA = "0xAFA234", Offset = "0xAFA234", VA = "0xAFA234")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000994")]
		[Address(RVA = "0xAFA240", Offset = "0xAFA240", VA = "0xAFA240")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000186")]
	public Health Health
	{
		[Token(Token = "0x6000995")]
		[Address(RVA = "0xAFA410", Offset = "0xAFA410", VA = "0xAFA410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000187")]
	public bool Alive
	{
		[Token(Token = "0x6000996")]
		[Address(RVA = "0xAFA418", Offset = "0xAFA418", VA = "0xAFA418")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400001B")]
	public static event EventHandler<DeathEvent> OnDying
	{
		[Token(Token = "0x6000998")]
		[Address(RVA = "0xAFA438", Offset = "0xAFA438", VA = "0xAFA438")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612C98", Offset = "0x612C98")]
		add
		{
		}
		[Token(Token = "0x6000999")]
		[Address(RVA = "0xAFA4F4", Offset = "0xAFA4F4", VA = "0xAFA4F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612CA8", Offset = "0x612CA8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public static event EventHandler<DeathEvent> OnDied
	{
		[Token(Token = "0x600099A")]
		[Address(RVA = "0xAFA5B0", Offset = "0xAFA5B0", VA = "0xAFA5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612CB8", Offset = "0x612CB8")]
		add
		{
		}
		[Token(Token = "0x600099B")]
		[Address(RVA = "0xAFA670", Offset = "0xAFA670", VA = "0xAFA670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612CC8", Offset = "0x612CC8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0xAFA434", Offset = "0xAFA434", VA = "0xAFA434", Slot = "16")]
	protected virtual void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0xAFA730", Offset = "0xAFA730", VA = "0xAFA730")]
	protected void OnDeath(int witnessCount, Damage damage)
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0xAFA814", Offset = "0xAFA814", VA = "0xAFA814", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0xAFA91C", Offset = "0xAFA91C", VA = "0xAFA91C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0xAFAA1C", Offset = "0xAFAA1C", VA = "0xAFAA1C")]
	public void Despawn()
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0xAFAB38", Offset = "0xAFAB38", VA = "0xAFAB38")]
	protected Character()
	{
	}
}
