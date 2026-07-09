using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000124")]
public class NPCFilter
{
	[Token(Token = "0x2000125")]
	public enum HealthConditions
	{
		[Token(Token = "0x4000664")]
		Any = 0,
		[Token(Token = "0x4000665")]
		Alive = 1,
		[Token(Token = "0x4000666")]
		Full = 2,
		[Token(Token = "0x4000667")]
		Wounded = 3,
		[Token(Token = "0x4000668")]
		Dead = 4
	}

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x10")]
	public float MinDistance;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B07B4", Offset = "0x5B07B4")]
	public FsmFloat MinDistanceVar;

	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x20")]
	public float MaxDistance;

	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B07C8", Offset = "0x5B07C8")]
	public FsmFloat MaxDistanceVar;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x30")]
	public Faction[] Faction;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x38")]
	public Faction.Relationship[] Relationship;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] NPCSpawner;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x48")]
	private List<Spawner> _flattenedSpawners;

	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x50")]
	public BehaviourEvaluator[] Behaviours;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x58")]
	public HealthConditions HealthCondition;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x60")]
	public Faction RelativeFaction;

	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 RelativePosition;

	[Token(Token = "0x17000150")]
	public float MinDist
	{
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xC53288", Offset = "0xC53288", VA = "0xC53288")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000151")]
	public float MaxDist
	{
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xC532EC", Offset = "0xC532EC", VA = "0xC532EC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xC531F0", Offset = "0xC531F0", VA = "0xC531F0")]
	public static bool CheckHealth(HealthConditions condition, Health health)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xC53350", Offset = "0xC53350", VA = "0xC53350")]
	public bool SatisfiedBy(Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xC53700", Offset = "0xC53700", VA = "0xC53700")]
	private void FlattenSpawners()
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0xC53880", Offset = "0xC53880", VA = "0xC53880")]
	public bool SatisfiedBy(Character character, bool checkDist = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0xC53920", Offset = "0xC53920", VA = "0xC53920")]
	public bool SatisfiedBy(Memory memory)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0xC52770", Offset = "0xC52770", VA = "0xC52770")]
	public bool SatisfiedBy(AIController ai, bool checkDist = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0xC539E0", Offset = "0xC539E0", VA = "0xC539E0")]
	public NPCFilter()
	{
	}
}
