using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D5")]
public class RandomInRadius : Waypoint
{
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0xE8")]
	public float RandomRadius;

	[Token(Token = "0x6000651")]
	[Address(RVA = "0xB3E570", Offset = "0xB3E570", VA = "0xB3E570", Slot = "18")]
	public override Vector3 GetDestination(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0xB3E5CC", Offset = "0xB3E5CC", VA = "0xB3E5CC")]
	private new void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0xB3E70C", Offset = "0xB3E70C", VA = "0xB3E70C")]
	public RandomInRadius()
	{
	}
}
