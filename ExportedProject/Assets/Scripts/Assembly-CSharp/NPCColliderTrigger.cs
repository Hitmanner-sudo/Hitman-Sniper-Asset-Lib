using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000122")]
public class NPCColliderTrigger : NPCTriggerBase
{
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x68")]
	protected readonly List<AIController> PotentiallyInside;

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x70")]
	private readonly Dictionary<Collider, int> _contactCount;

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0xC523D4", Offset = "0xC523D4", VA = "0xC523D4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0xC52648", Offset = "0xC52648", VA = "0xC52648", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0xC52754", Offset = "0xC52754", VA = "0xC52754", Slot = "16")]
	protected virtual bool SatisfiedBy(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x60007EF")]
	[Address(RVA = "0xC52A74", Offset = "0xC52A74", VA = "0xC52A74")]
	protected void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xC52D2C", Offset = "0xC52D2C", VA = "0xC52D2C")]
	protected void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xC52C84", Offset = "0xC52C84", VA = "0xC52C84")]
	private int IncrementContactCount(Collider col)
	{
		return default(int);
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xC52EF0", Offset = "0xC52EF0", VA = "0xC52EF0")]
	private int DecrementContactCount(Collider col)
	{
		return default(int);
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0xC52F98", Offset = "0xC52F98", VA = "0xC52F98")]
	public void ColliderInsideWasDisabled(Collider col)
	{
	}

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0xC52F9C", Offset = "0xC52F9C", VA = "0xC52F9C")]
	public NPCColliderTrigger()
	{
	}
}
