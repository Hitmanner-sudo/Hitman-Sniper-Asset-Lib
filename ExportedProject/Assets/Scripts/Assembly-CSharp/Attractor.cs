using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000C5")]
public abstract class Attractor : GameMonoBehaviour
{
	[Token(Token = "0x20000C6")]
	public class UseCompleteArgs : EventArgs
	{
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B040C", Offset = "0x5B040C")]
		private Attractor _003CAttractor_003Ek__BackingField;

		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B041C", Offset = "0x5B041C")]
		private AIController _003CAI_003Ek__BackingField;

		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x20")]
		public bool Successful;

		[Token(Token = "0x1700012A")]
		public Attractor Attractor
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x92548C", Offset = "0x92548C", VA = "0x92548C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612030", Offset = "0x612030")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x925494", Offset = "0x925494", VA = "0x925494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612040", Offset = "0x612040")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public AIController AI
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x92549C", Offset = "0x92549C", VA = "0x92549C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612050", Offset = "0x612050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x9254A4", Offset = "0x9254A4", VA = "0x9254A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612060", Offset = "0x612060")]
			set
			{
			}
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x925428", Offset = "0x925428", VA = "0x925428")]
		public UseCompleteArgs()
		{
		}
	}

	[Token(Token = "0x20000C7")]
	public enum FilterType
	{
		[Token(Token = "0x40004B0")]
		CanKeepUsing = 0,
		[Token(Token = "0x40004B1")]
		TooManyUsers = 1,
		[Token(Token = "0x40004B2")]
		Faction = 2,
		[Token(Token = "0x40004B3")]
		Spawner = 3,
		[Token(Token = "0x40004B4")]
		Gender = 4,
		[Token(Token = "0x40004B5")]
		Cooldown = 5,
		[Token(Token = "0x40004B6")]
		InfiniteCooldown = 6,
		[Token(Token = "0x40004B7")]
		AttractionZone = 7,
		[Token(Token = "0x40004B8")]
		AttractionRadius = 8,
		[Token(Token = "0x40004B9")]
		TotalVisitCount = 9,
		[Token(Token = "0x40004BA")]
		UserVisitCount = 10,
		[Token(Token = "0x40004BB")]
		Unreachable = 11,
		[Token(Token = "0x40004BC")]
		Broken = 12,
		[Token(Token = "0x40004BD")]
		NoPatrolPoints = 13,
		[Token(Token = "0x40004BE")]
		Allowed = 14
	}

	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5923D8", Offset = "0x5923D8")]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x10")]
		public AIController ai;

		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x18")]
		public Attractor _003C_003E4__this;

		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x20")]
		public bool success;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x9253A8", Offset = "0x9253A8", VA = "0x9253A8")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x9253B0", Offset = "0x9253B0", VA = "0x9253B0")]
		internal UseCompleteArgs _003CUseCompleted_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	private bool _advertise;

	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x48")]
	private bool _advertised;

	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x4C")]
	public float AttractionRadius;

	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x50")]
	public NPCTriggerBase[] AttractionZones;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x58")]
	public int MaxNumberOfUsers;

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x5C")]
	public float CooldownTime;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x60")]
	public Faction Faction;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x68")]
	public List<Faction> Factions;

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x70")]
	public Spawner[] SpawnerList;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x78")]
	public int Priority;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x7C")]
	public int MaxVisitsPerUser;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x80")]
	public int MaxVisitsTotal;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x84")]
	private int UseCount;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x88")]
	public AlertLevel MinAlertLevel;

	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x8C")]
	public AlertLevel MaxAlertLevel;

	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x90")]
	protected float LastUseTime;

	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x98")]
	protected List<AIController> _users;

	[Token(Token = "0x17000128")]
	public bool Advertise
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xC06038", Offset = "0xC06038", VA = "0xC06038")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xC06040", Offset = "0xC06040", VA = "0xC06040")]
		set
		{
		}
	}

	[Token(Token = "0x17000129")]
	public List<AIController> Users
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xC06068", Offset = "0xC06068", VA = "0xC06068")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000008")]
	public event EventHandler<UseCompleteArgs> OnUseCompleted
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xC06070", Offset = "0xC06070", VA = "0xC06070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612010", Offset = "0x612010")]
		add
		{
		}
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xC06110", Offset = "0xC06110", VA = "0xC06110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612020", Offset = "0x612020")]
		remove
		{
		}
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0xC061B0", Offset = "0xC061B0", VA = "0xC061B0")]
	public bool CanBeUsedBy(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0xC061D8", Offset = "0xC061D8", VA = "0xC061D8", Slot = "14")]
	public virtual FilterType Filter(AIController ai)
	{
		return default(FilterType);
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0xC066BC", Offset = "0xC066BC", VA = "0xC066BC", Slot = "15")]
	public virtual bool CanKeepUsing(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0xC067A0", Offset = "0xC067A0", VA = "0xC067A0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0xC0683C", Offset = "0xC0683C", VA = "0xC0683C", Slot = "16")]
	protected virtual void Register()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0xC068D0", Offset = "0xC068D0", VA = "0xC068D0", Slot = "17")]
	protected virtual void UnRegister()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0xC06960", Offset = "0xC06960", VA = "0xC06960", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0xC069F4", Offset = "0xC069F4", VA = "0xC069F4", Slot = "18")]
	public virtual Vector3 GetDestination(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0xC06A10", Offset = "0xC06A10", VA = "0xC06A10", Slot = "19")]
	public virtual Vector3 GetDirection(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0xC06A2C", Offset = "0xC06A2C", VA = "0xC06A2C", Slot = "20")]
	public virtual void StartUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0xC06B84", Offset = "0xC06B84", VA = "0xC06B84", Slot = "21")]
	public virtual void StopUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0xC06BE8", Offset = "0xC06BE8", VA = "0xC06BE8", Slot = "22")]
	public virtual bool IsUsing(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0xBFF674", Offset = "0xBFF674", VA = "0xBFF674", Slot = "23")]
	public virtual void UseCompleted(AIController ai, bool success)
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0xC06BF0", Offset = "0xC06BF0", VA = "0xC06BF0", Slot = "24")]
	public virtual float GetDistanceSqr(AIController ai)
	{
		return default(float);
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0xC06C8C", Offset = "0xC06C8C", VA = "0xC06C8C", Slot = "25")]
	protected virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0xC06F24", Offset = "0xC06F24", VA = "0xC06F24", Slot = "26")]
	protected virtual void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0xC070A4", Offset = "0xC070A4", VA = "0xC070A4")]
	protected Attractor()
	{
	}
}
