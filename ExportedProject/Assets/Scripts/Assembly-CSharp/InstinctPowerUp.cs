using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000341")]
public class InstinctPowerUp : PowerUp
{
	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private bool _penetrateEverything;

	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0xA1")]
	private bool _oldPenetrateEverything;

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0xB1408C", Offset = "0xB1408C", VA = "0xB1408C", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0xB14138", Offset = "0xB14138", VA = "0xB14138", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0xB141DC", Offset = "0xB141DC", VA = "0xB141DC")]
	public InstinctPowerUp()
	{
	}
}
