using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000317")]
public class Rotate : GameMonoBehaviour
{
	[Token(Token = "0x400114E")]
	[FieldOffset(Offset = "0x48")]
	public float RotationsPerSecond;

	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 LocalAxis;

	[Token(Token = "0x6001301")]
	[Address(RVA = "0xBA4298", Offset = "0xBA4298", VA = "0xBA4298", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6001302")]
	[Address(RVA = "0xBA4394", Offset = "0xBA4394", VA = "0xBA4394")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001303")]
	[Address(RVA = "0xBA4800", Offset = "0xBA4800", VA = "0xBA4800")]
	public Rotate()
	{
	}
}
