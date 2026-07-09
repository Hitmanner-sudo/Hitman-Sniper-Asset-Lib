using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000CD")]
public class InvestigationOverride : CompositeTrigger
{
	[NonSerialized]
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x60")]
	public List<Attractor> InvestigationPoints;

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x10BCCC0", Offset = "0x10BCCC0", VA = "0x10BCCC0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x10BCD44", Offset = "0x10BCD44", VA = "0x10BCD44", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x10BD0A0", Offset = "0x10BD0A0", VA = "0x10BD0A0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x10BD16C", Offset = "0x10BD16C", VA = "0x10BD16C")]
	public bool Contains(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x10BD240", Offset = "0x10BD240", VA = "0x10BD240")]
	public InvestigationOverride()
	{
	}
}
