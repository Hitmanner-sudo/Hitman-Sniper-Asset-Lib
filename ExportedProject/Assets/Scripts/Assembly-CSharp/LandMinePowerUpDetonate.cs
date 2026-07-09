using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000345")]
public class LandMinePowerUpDetonate : PowerUp
{
	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private bool _delayOnFirstMine;

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x994934", Offset = "0x994934", VA = "0x994934", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x994AC4", Offset = "0x994AC4", VA = "0x994AC4")]
	public LandMinePowerUpDetonate()
	{
	}
}
