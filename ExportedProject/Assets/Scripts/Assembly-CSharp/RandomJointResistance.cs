using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000128")]
public class RandomJointResistance : MonoBehaviour
{
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x18")]
	public float BreakMinForce;

	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x1C")]
	public float BreakMaxForce;

	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x20")]
	public float BreakMinTorque;

	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x24")]
	public float BreakMaxTorque;

	[Token(Token = "0x600080C")]
	[Address(RVA = "0xB3E8F8", Offset = "0xB3E8F8", VA = "0xB3E8F8")]
	public void EnableDismemberment(bool enable)
	{
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0xB3EA90", Offset = "0xB3EA90", VA = "0xB3EA90")]
	public RandomJointResistance()
	{
	}
}
